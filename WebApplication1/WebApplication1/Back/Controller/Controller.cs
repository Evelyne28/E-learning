using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Back.Models;
using WebApplication1.Back.RepositoryNamespace;

namespace WebApplication1.Back.ControllerNamespace
{
    public class Controller
    {
        private Repository repo;
        public Controller()
        {
            this.repo = new Repository();
        }

        public List<Utilizator> getUsers()
        {
            return repo.getUsers();
        }

        public Utilizator findUser(String nume, String parola)
        {
            return repo.findUser(nume, parola);
        }

        public int findUserIdentity(Utilizator u)
        {
            return repo.findUserIdentity(u);
        }

        public bool adaugaUtiliz(int id,string nume,string prenume,string email,string telefon,int rol, string user, string parola)
        {
            return repo.adaugaUtiliz(id,nume,prenume,email,telefon,rol, user, parola);
        }

        public bool stergeUtiliz(int id)
        {
            return repo.stergeUtiliz(id);
        }

        public bool modificaUtiliz(int id, string numeN, string prenumeN, string emailN, string telefonN, string parolaN)
        {
            return repo.modificaUtiliz(id, numeN, prenumeN, emailN, telefonN,parolaN);
        }
    }
}