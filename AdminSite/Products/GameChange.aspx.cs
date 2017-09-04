using Business;
using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminSite.Products
{
    public partial class GameChange : System.Web.UI.Page
    {
        GameBussines gameBusiness;
        List<Game> games;
        String idGame;
        Game product;
        protected void Page_Load(object sender, EventArgs e)
        {
            tbNameProductU.Attributes.Add("placeholder", "Nombre del Juego");
            tbPriceU.Attributes.Add("placeholder", "Price");
            charge();
        }

        private void charge()
        {
            this.gameBusiness = new GameBussines();
            this.games = gameBusiness.allGames();
            idGame = Convert.ToString(Request.QueryString["id"]);
            foreach (Game game in this.games)
            {
                if (this.idGame.Equals(game.IdGame))
                {
                    tbNameProductU.Text = game.Name;
                    typeListU.SelectedValue = game.Type;
                    consoleListU.SelectedValue = game.Consol;
                    tbPriceU.Text =""+ game.Price;
                    product = game;
                    
                }
            }



            }

        protected void ButtonU_Click(object sender, EventArgs e)
        {

            if ((String)typeListU.SelectedValue != "0" && (String)consoleListU.SelectedValue != "0")
            {
                this.gameBusiness.deleteGame(this.product.IdGame);
                Game game = new Game(tbNameProductU.Text, typeListU.SelectedValue, consoleListU.SelectedValue, float.Parse(tbPriceU.Text));
                GameBussines gameBusiness = new GameBussines();
                gameBusiness.insertGame(game);
            }

            Response.Redirect("~/Products/Products.aspx");


        }

        protected void ButtonD_Click(object sender, EventArgs e)
        {
            this.gameBusiness.deleteGame(this.product.IdGame);
            Response.Redirect("~/Products/Products.aspx");
        }

        protected void tbNameProductU_TextChanged(object sender, EventArgs e)
        {
            tbNameProductU.Attributes.Add("placeholder", "Name of Product");
        }
        protected void tbPriceProductU_TextChanged(object sender, EventArgs e)
        {
            tbNameProductU.Attributes.Add("placeholder", "Price");
        }
    }
}