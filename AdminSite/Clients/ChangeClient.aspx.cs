using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite.Products
{
    public partial class ChangeClient : System.Web.UI.Page
    {
        ClientBussines clientBusiness;
        List<Domain.Client> clients;
        String idClient;
        Domain.Client userClient;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            tbNameClient.Attributes.Add("placeholder", "Name");
            tbUserClient.Attributes.Add("placeholder", "Email");
            tbNameClient.Attributes.Add("placeholder", "Password");
            tbUserClient.Attributes.Add("placeholder", "Date of Birth");
            charge();
        }

        private void charge()
        {
            this.clientBusiness = new ClientBussines();
            this.clients = clientBusiness.clients();
            idClient = Convert.ToString(Request.QueryString["id"]);
            foreach (Domain.Client game in this.clients)
            {
                if (this.idClient.Equals(game.IdClient))
                {
                    tbNameClient.Text = game.Name;
                    tbUserClient.Text = game.Email;
                    tbPassClient.Text = game.Password;
                    tbBorn.Text = "" + game.Birthday;
                    userClient = game;

                }
            }
        }

        protected void tbNameClient_TextChanged(object sender, EventArgs e)
        {
            tbNameClient.Attributes.Add("placeholder", "Name");
        }

        protected void tbUserClient_TextChanged(object sender, EventArgs e)
        {
            tbUserClient.Attributes.Add("placeholder", "Email");
        }

        protected void tbPassClient_TextChanged(object sender, EventArgs e)
        {
            tbNameClient.Attributes.Add("placeholder", "Password");
        }

        protected void tbBorn_TextChanged(object sender, EventArgs e)
        {
            tbUserClient.Attributes.Add("placeholder", "Date of Birth");
        }

        

       
        protected void ButtonU_Click(object sender, EventArgs e)
        {

            this.clientBusiness.updateClient(this.userClient);
            Response.Redirect("~/Clients/ViewClient.aspx");
        }

        protected void ButtonD_Click(object sender, EventArgs e)
        {
            this.clientBusiness.deletClient(this.userClient.Email);
            Response.Redirect("~/Clients/ViewClient.aspx");
        }
    }
}