using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Back.ControllerNamespace;
using WebApplication1.Back.Models;

namespace WebApplication1.Web_forms
{
    public partial class Admin_start : System.Web.UI.Page
    {
        private Controller controller;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Adauga_Click(object sender, EventArgs e)
        {
            try{
            controller = new Controller();
            string id="", nume="", prenume="", email="", telefon="", rol="", username="", parola="";
            if (!string.IsNullOrEmpty(Request.Form["idUtilizator"]))
            {
                id = Request.Form["idUtilizator"];
            }
            if (!string.IsNullOrEmpty(Request.Form["nume"]))
            {
                nume = Request.Form["nume"];
            }
            if (!string.IsNullOrEmpty(Request.Form["prenume"]))
            {
                prenume = Request.Form["prenume"];
            }
            if (!string.IsNullOrEmpty(Request.Form["e-mail"]))
            {
                email = Request.Form["e-mail"];
            }
            if (!string.IsNullOrEmpty(Request.Form["telefon"]))
            {
                telefon = Request.Form["telefon"];
            }
            if (!string.IsNullOrEmpty(Request.Form["rol"]))
            {
                rol = Request.Form["rol"];
            }
            if (!string.IsNullOrEmpty(Request.Form["userName"]))
            {
                username = Request.Form["userName"];
            }
            if (!string.IsNullOrEmpty(Request.Form["parola"]))
            {
                parola = Request.Form["parola"];
            }
           
                if (controller.adaugaUtiliz(Int32.Parse(id), nume, prenume, email, telefon, Int32.Parse(rol), username, parola) == true)
                    Response.Write("Adaugare realizata cu succes!");
                else
                    Response.Write("Exista deja un utilizator cu acest id!");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Sterge_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new Controller();
                string id = "";
                if (!string.IsNullOrEmpty(Request.Form["idUtilizator"]))
                {
                    id = Request.Form["idUtilizator"];
                }
                if (controller.stergeUtiliz(Int32.Parse(id)))
                    Response.Write("Stergere realizata cu succes!");
                else
                    Response.Write("Nu exista utilizatorul cu id-ul dat!");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btn_Modifica_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new Controller();
                string id = "", nume = "", prenume = "", email = "", telefon = "", parola = "";
                if (!string.IsNullOrEmpty(Request.Form["idUtilizator"]))
                {
                    id = Request.Form["idUtilizator"];
                }
                if (!string.IsNullOrEmpty(Request.Form["nume"]))
                {
                    nume = Request.Form["nume"];
                }
                if (!string.IsNullOrEmpty(Request.Form["prenume"]))
                {
                    prenume = Request.Form["prenume"];
                }
                if (!string.IsNullOrEmpty(Request.Form["e-mail"]))
                {
                    email = Request.Form["e-mail"];
                }
                if (!string.IsNullOrEmpty(Request.Form["telefon"]))
                {
                    telefon = Request.Form["telefon"];
                }
               
                if (!string.IsNullOrEmpty(Request.Form["parola"]))
                {
                    parola = Request.Form["parola"];
                }
                if(controller.modificaUtiliz(Int32.Parse(id),nume,prenume,email,telefon,parola)==true)
                    Response.Write("Modificare realizata cu succes!");
                else
                    Response.Write("Nu exista niciun utilizator cu id-ul dat!");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}