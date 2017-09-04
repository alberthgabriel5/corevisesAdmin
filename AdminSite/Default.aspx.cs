using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbEmail.Attributes.Add("placeholder", "E-mail@server.com");
            tbPassword.Attributes.Add("placeholder", "Password");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String user = (String)tbEmail.Text;
            String session = tbPassword.Text;
            AdministratorBussines admin = new AdministratorBussines();
            Administrator admi = new Administrator(user, session);
            

            if (admin.initSession(admi)==1)
            {

                Session["user"] = (String)tbEmail.Text;
                Session["session"] = tbPassword.Text;
                Session["page"] = "index";

                Response.Redirect("~/index.aspx");
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void tbEmail_TextChanged(object sender, EventArgs e)
        {
            tbEmail.Attributes.Add("placeholder", "e-mail@server.com");
        }
    }
}