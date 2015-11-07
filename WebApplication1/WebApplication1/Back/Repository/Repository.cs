using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Back.Models;
using System.Data.Odbc;
using System.Web.Configuration;
using WebApplication1.Back.Models;

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
            ResearchersEntities context = new ResearchersEntities();
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
            users = new List<Utilizator>();
            ResearchersEntities context = new ResearchersEntities();
            var load = from a in context.Utilizator select a;
            if (load != null)
            {
                users = load.ToList();
            }
            return this.users;
        }
    }
}