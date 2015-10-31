using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Back.Models
{
    public class User
    {
        public int idUser;
        public String name;
        public String password;
        public String eMail;
        public DateTime birthDate;
        public int status;

        public User() { }
        public User(int idUser, String name, String password, String eMail, DateTime birthDate, int status)
        {
            this.idUser = idUser;
            this.name = name;
            this.password = password;
            this.eMail = eMail;
            this.birthDate = birthDate;
            this.status = status;
        }

        public int getIdUser()
        {
            return idUser;
        }

        public void setIdUser(int idUser)
        {
            this.idUser = idUser;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getPassword()
        {
            return this.password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getEMail()
        {
            return this.eMail;
        }

        public void setEMail(String eMail)
        {
            this.eMail = eMail;
        }

        public DateTime getBirthDate()
        {
            return this.birthDate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public int getStatus()
        {
            return this.status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }

        public String toString()
        {
            return "ID = " + idUser + ", Name = " + name + ", Password = " + password + ", e-mail = " + eMail
                + ", Birthdate = " + birthDate.ToString() + ", status = " + status;
        }
    }
}