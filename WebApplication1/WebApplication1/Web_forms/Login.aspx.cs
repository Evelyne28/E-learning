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
    public partial class Login : System.Web.UI.Page
    {
        private Controller controller;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btn_login_Click(object sender, EventArgs e)
        {
            controller = new Controller();
            string userName = "", password = "";
            if (!string.IsNullOrEmpty(Request.Form["userName"]))
            {
                userName = Request.Form["userName"];
            }

            if (!string.IsNullOrEmpty(Request.Form["userPassword"]))
            {
                password = Request.Form["userPassword"];
            }
            try
            {
                Utilizator u = controller.findUser(userName, password);

                int rol = controller.findUserIdentity(u);
                //in functie de rolul gasit se afiseaza pagina corespunzatoare
                if (u != null && rol == 0)
                {
                    Session["userName"] = userName;
                    Session["userPassword"] = password;
                    Response.Redirect("Profesor_start.aspx");
                }
                else if (u != null && rol == 1)
                {
                    Session["userName"] = userName;
                    Session["userPassword"] = password;
                    Response.Redirect("Profesor_start.aspx");
                }
                else if (u != null && rol == 2)
                {
                    Session["userName"] = userName;
                    Session["userPassword"] = password;
                    Response.Redirect("Profesor_start.aspx");
                }
               

                else if (u != null && rol == 3)
                {
                    Session["userName"] = userName;
                    Session["userPassword"] = password;
                    Response.Redirect("Asistent_start.aspx");
                }
               
            }
            catch (Exception)
            {
                Response.Write("User-ul sau parola sunt introduse gresit");
            }
        }
    }
}
