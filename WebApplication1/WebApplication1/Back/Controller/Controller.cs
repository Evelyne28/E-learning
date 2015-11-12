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
    }
}