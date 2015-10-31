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
        public List<User> users;
        public Repository()
        {
            this.users = new List<User>();
            populate();
        }

        public void populate()
        {
            try
            {
                using (OdbcConnection connection = new OdbcConnection(WebConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    connection.Open();
                    using (OdbcCommand command = new OdbcCommand("SELECT * FROM User", connection))
                    using (OdbcDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idUser = Convert.ToInt32(dr["idUser"].ToString());
                            String name = dr["name"].ToString();
                            String password = dr["password"].ToString();
                            String eMail = dr["eMail"].ToString();
                            DateTime birthDate = Convert.ToDateTime(dr["birthdate"].ToString());
                            int status = Convert.ToInt32(dr["status"].ToString());
                            User user = new User(idUser, name, password, eMail, birthDate, status);
                            users.Add(user);
                            //Response.Write(dr["nameB"].ToString() + "<br />");
                        }
                        dr.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //Response.Write("An error occured: " + ex.Message);
                users = null;
            }
        }

        public User findUser(String username, String userpassword)
        {
            User user = null;
            try
            {
                using (OdbcConnection connection = new OdbcConnection(WebConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    connection.Open();
                    using (OdbcCommand command = new OdbcCommand("SELECT * FROM User where name = '" + username + "' and  password = '" + userpassword + "'", connection))
                    using (OdbcDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idUser = Convert.ToInt32(dr["idUser"].ToString());
                            String name = dr["name"].ToString();
                            String password = dr["password"].ToString();
                            String eMail = dr["eMail"].ToString();
                            DateTime birthDate = Convert.ToDateTime(dr["birthdate"].ToString());
                            int status = Convert.ToInt32(dr["status"].ToString());
                            user = new User(idUser, name, password, eMail, birthDate, status);
                           // Response.Write(dr["nameB"].ToString() + "<br />");
                        }
                        dr.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //Response.Write("An error occured: " + ex.Message);
                user = null;
            }
            return user;
        }

        public List<User> getUsers()
        {
            return this.users;
        }
    }
}