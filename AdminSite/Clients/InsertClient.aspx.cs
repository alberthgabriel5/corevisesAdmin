using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite.Products
{
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientBussines clientBusines = new ClientBussines();
            Domain.Client client = new Domain.Client(tbUserClient.Text, tbPassClient.Text, tbNameClient.Text,tbBorn.Text);
            clientBusines.insertClient(client);
            Response.Redirect("~/ Clients / ViewClient.aspx");
        }

      

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        
    }
}