using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebCore
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCore : System.Web.Services.WebService
    {

        [WebMethod]
        
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        //conusmo para WebSite
        [WebMethod]
        public int insertClient(string email, string password, string name, string birthday)
        {
            var client = new Client() { Email = email, Password = password, Name = name, Birthday = birthday };
            ClientBussines clienBusi = new ClientBussines();
            clienBusi.insertClient(client);

            return 1;
        }//insertClient
        [WebMethod]
        public int initSessionClient(string email,string password)
        {
            ClientBussines clienBusi = new ClientBussines();
            return clienBusi.initSession(email,password);
        }//initSession

        [WebMethod]
        public int initSessionAdmi(string user, string password)
        {
            AdministratorBussines admiiBu = new AdministratorBussines();
            var admi = new Administrator() { User = user ,Password = password };
            return admiiBu.initSession(admi);
        }//initSession

        //lista de juegos 


        [WebMethod]
        public String games()
        {                                                                                                                     
            GameBussines gameBussi = new GameBussines();
            var jsonSeri = new JavaScriptSerializer();
            var json = jsonSeri.Serialize(gameBussi.allGames().ToArray());

            return json;


        }//games

        [WebMethod]
        
        public String administrators()
        {
            AdministratorBussines admiBusii = new AdministratorBussines();
            var jsonSeri = new JavaScriptSerializer();
            var json = jsonSeri.Serialize(admiBusii.administrator());

            return json;
        }//administrators

    }//end class
}//end namespace
