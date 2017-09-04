using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite.Products
{
    public partial class ViewClient : System.Web.UI.Page
    {
        ClientBussines clientBusiness;
        List<Domain.Client> clients;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.clientBusiness = new ClientBussines();
            LoadImages();

        }

        private void LoadImages()
        {
            this.clients = clientBusiness.clients();

            foreach (Domain.Client client in clients)
            {

                Panel pGame = new Panel();
                ImageButton imageButton = new ImageButton();
                imageButton.ImageUrl = "/img/icons/People.png";
                imageButton.Style.Add("padding", "5px");
                imageButton.Height = Unit.Pixel(100);
                imageButton.Width = Unit.Pixel(100);
                imageButton.CssClass = "mx-auto rounded-circle";
                imageButton.Click += new ImageClickEventHandler(delegate (object sender, ImageClickEventArgs e) {
                    Response.Redirect("~/Clients/ChangeClient.aspx?id=" + client.IdClient);
                });
                Label lblName1 = new Label();
                lblName1.Text = client.Name;
                lblName1.CssClass = "h4";
                Label lblName2 = new Label();
                lblName2.Text = client.Birthday;
                lblName2.CssClass = "text-muted";
                
                pGame.CssClass = "team-member";
                pGame.Controls.Add(imageButton);
                pGame.Controls.Add(new LiteralControl("<BR>"));
                pGame.Controls.Add(lblName1);
                pGame.Controls.Add(new LiteralControl("<BR>"));
                pGame.Controls.Add(lblName2);
                pGame.Controls.Add(new LiteralControl("<BR>"));                
                PanelList.Controls.Add(pGame);
            }
            PanelList.CssClass = "row";
        }
    } 
}