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

        public List<User> getUsers()
        {
            return repo.getUsers();
        }

        public User findUser(String name, String password)
        {
            Console.WriteLine("findUser" + name + password);
            return repo.findUser(name, password);
        }
    }
}