using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Back.Models;
using System.Data.Odbc;
using System.Web.Configuration;

namespace WebApplication1.Back.RepositoryNamespace
{
    public class Repository
    {
        public List<Utilizator> users;
        public List<Profesor> profesori;
        public Repository()
        {
            this.users = this.getUsers();
            this.profesori = this.getListaProfesori();
        }

       
        //gaseste utilizatorul dupa user si parola si il returneaza
        public Utilizator findUser(String nume, String parola)
        {
            List<Utilizator> lista = this.getUsers();
            foreach (Utilizator u in lista)
            {
                if (u.username.Equals(nume) && u.parola.Equals(parola))
                    return u;
            }
            return null;
        }

        //returneaza rolul utilizatorului (0=admin; 1=student; 2=profesor; 3=asistent)
        public int findUserIdentity(Utilizator ut)
        {
            return (int)ut.rol;
        }

        //returneaza profesorul in functie de id
        public Profesor getProfesor(int id)
        {
            foreach (Profesor p in profesori)
            {
                if (p.id == id)
                    return p;
            }
            return null;
        }

        //populeaza lista de profesori din baza de date si o returneaza
        public List<Profesor> getListaProfesori()
        {
            profesori = new List<Profesor>();
            ResearchersEntities4 context = new ResearchersEntities4();
            var load = from a in context.Profesor select a;
            if (load != null)
            {
                profesori = load.ToList();
            }
            return this.profesori;
        }

       
        //populeaza lista de utilizatori din baza de date si o returneaza
        public List<Utilizator> getUsers()
        {
            ResearchersEntities4 context = new ResearchersEntities4();
            users = new List<Utilizator>();
            var load = from a in context.Utilizator select a;
            if (load != null)
            {
                try
                {
                    users = load.ToList();
                }
                catch (Exception ex)
                {
                    string exx = ex.InnerException.ToString();
                }
            }
            return this.users;
        }

        //cauta un utilizator dupa id
        public bool cauta(int id)
        {
            List<Utilizator> ut = getUsers();
            for (int i = 0; i < ut.Count; i++)
            {
                if (ut.ElementAt(i).id == id)
                    return true;
            }
            return false;
        }

        //adauga un utilizator
        public bool adaugaUtiliz(int id,string nume,string prenume,string email,string telefon,int rol, string user,string parola)
        {
            ResearchersEntities4 context = new ResearchersEntities4();
            if (cauta(id)) return false;
            Utilizator u = new Utilizator(id, user, parola, rol);
            context.Utilizator.Add(u);
            if (rol == 1)
            {
                Student s = new Student(id, nume, prenume, telefon, email);
                context.Student.Add(s);
                context.SaveChanges();
                return true;
            }
            else if (rol == 2)
            {
                Profesor p = new Profesor(id, nume, prenume);
                context.Profesor.Add(p);
                context.SaveChanges();
                return true;
            }
            else if (rol == 3)
            {
                Asistent a = new Asistent(id, nume, prenume);
                context.Asistent.Add(a);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        //sterge un utilizator
        public bool stergeUtiliz(int id)
        {
            ResearchersEntities4 context = new ResearchersEntities4();
            if (cauta(id) == false)
                return false;
            List<Utilizator> ut = getUsers();
            int rol=0;
            for (int i = 0; i < ut.Count; i++)
                if (ut.ElementAt(i).id == id)
                {
                    rol = (int) ut.ElementAt(i).rol;
                    break;
                }
            if (rol == 1)
            {
                Student s = context.Student.Find(id);
                context.Student.Remove(s);
            }
            else if (rol == 2)
            {
                Profesor p = context.Profesor.Find(id);
                context.Profesor.Remove(p);
            }
            else if (rol == 3)
            {
                Asistent a = context.Asistent.Find(id);
                context.Asistent.Remove(a);
            }
            else
                return false;
            Utilizator u = context.Utilizator.Find(id);
            context.Utilizator.Remove(u);
            context.SaveChanges();
            return true;
        }

        //modifica un utilizator
        public bool modificaUtiliz(int id, string numeN, string prenumeN, string emailN, string telefonN, string parolaN)
        {
            ResearchersEntities4 context = new ResearchersEntities4();
            if (cauta(id) == false)
                return false;
            Utilizator u = context.Utilizator.Find(id);
            int r =(int) u.rol;
            if (r == 1)
            {
                Student st = context.Student.Find(id);
                st.nume = numeN;
                st.prenume = prenumeN;
                st.telefon = telefonN;
                st.email = emailN;
            }
            else if (r == 2)
            {
                Profesor prof = context.Profesor.Find(id);
                prof.nume = numeN;
                prof.prenume = prenumeN;
            }
            else if (r == 3)
            {
                Asistent a = context.Asistent.Find(id);
                a.nume = numeN;
                a.prenume = prenumeN;
            }
            else
                return false;
            u.parola = parolaN;
            context.SaveChanges();
            return true;
        }
    }
}