using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;


namespace AdminSite.Products
{
    public partial class Products : System.Web.UI.Page
    {
        GameBussines gameBusiness;
        List<Game> games;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gameBusiness = new GameBussines();
            
            tbNameProduct.Attributes.Add("placeholder", "Name");
            tbPrice.Attributes.Add("placeholder", "Price");
            LoadImages();


        }

        private void LoadImages()
        {
            this.games = gameBusiness.allGames();

            foreach (Game game in this.games)
            {

                Panel pGame = new Panel();
                ImageButton imageButton = new ImageButton();
                imageButton.ImageUrl =this.pickLogo(game.Consol);
                imageButton.Style.Add("padding", "5px");
                imageButton.Height = Unit.Pixel(100);
                imageButton.Width = Unit.Pixel(100);
                imageButton.CssClass = "mx-auto rounded-circle";
                imageButton.Click += new ImageClickEventHandler(delegate(object sender, ImageClickEventArgs e){
                    Response.Redirect("~/Products/GameChange.aspx?id="+game.IdGame);
                });
                Label lblName1 = new Label();
                lblName1.Text = game.Name;
                lblName1.CssClass = "h4";
                Label lblName2 = new Label();
                lblName2.Text = this.typeGame(game.Type);
                lblName2.CssClass = "text-muted";
                Label lblName3 = new Label();
                lblName3.Text= this.console(game.Consol);
                lblName3.CssClass = "text-muted";
                pGame.CssClass = "team-member";
                pGame.Controls.Add(imageButton);
                pGame.Controls.Add(new LiteralControl("<BR>"));
                pGame.Controls.Add(lblName1);
                pGame.Controls.Add(new LiteralControl("<BR>"));
                pGame.Controls.Add(lblName2);
                pGame.Controls.Add(new LiteralControl("<BR>"));
                pGame.Controls.Add(lblName3);
                PanelListGame.Controls.Add(pGame);
                

            }
                PanelListGame.CssClass = "row";
          
        }     

      
        private string pickLogo(string console)
        {
            string result = "../img/logos/control.png";
            switch (console)
            {
                case "1":
                    result ="../img/game/xbox.jpg";
                    break;

                case "2":
                    result = "../img/game/PS3.jpg";
                    break;

                case "3":
                    result = "../img/game/PS4.jpg";
                    break;

                case "4":
                    result = "../img/game/wii.jpg";
                    break;
                default: result = "../img/logos/control.png"; break;
            }
            return result;
        }

        private string console(string console)
        {
            string result = "";
            switch (console)
            {
                case "1":
                    result = "Xbox 360";
                    break;

                case "2":
                    result = "Play Station 3";
                    break;

                case "3":
                    result = "Play Station 3";
                    break;

                case "4":
                    result = "Nintendo Wii";
                    break;
                default: result = "Consola Desconocida"; break;
            }
            return result;
        }

        private string typeGame(string console)
        {
            string result = "";
            switch (console)
            {
                case "1":
                    result = "Action";
                    break;

                case "2":
                    result = "Fight";
                    break;

                case "3":
                    result = "Kids";
                    break;

                case "4":
                    result = "Puzzle";
                    break;
                case "5":
                    result = "Race";
                    break;
                case "6":
                    result = "Simulation";
                    break;
                case "7":
                    result = "Sport";
                    break;
                case "8":
                    result = "Strategy";
                    break;


                default: result = "Consola Desconocida"; break;
            }
            return result;
        }

        protected void tbNameProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void ButtonI_Click(object sender, EventArgs e)
        {
            if((String)typeList.SelectedValue != "0" && (String)consoleList.SelectedValue != "0")
            {
                
                Game game = new Game(tbNameProduct.Text, typeList.SelectedValue, consoleList.SelectedValue, float.Parse(tbPrice.Text ));
                GameBussines gameBusiness = new GameBussines();
                gameBusiness.insertGame(game);
            }     
        }
    }
}