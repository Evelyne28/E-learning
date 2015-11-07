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
            User u = controller.findUser(userName, password);
            if (u != null)
            {
                Session["userName"] = userName;
                Session["userPassword"] = password;
                Response.Redirect("Profesor_start.aspx#jan");
            }
            else
                Response.Write("Incorrect!");
        }
    }
}
