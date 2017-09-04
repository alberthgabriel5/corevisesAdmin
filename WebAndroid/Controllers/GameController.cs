using Business;
using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAndroid.Controllers
{
    public class GameController : ApiController
    {
        public IHttpActionResult GetGames()
        {
            GameBussines busi = new GameBussines();
            return Json(busi.allGames().ToArray());
        }//Get


        public IHttpActionResult insert([FromBody]Game game)
        {
            GameBussines busi = new GameBussines();
            busi.insertGame(game);
            String json = JsonConvert.SerializeObject(game.ToString());
            return Json(new { Name = game.Name, Price = game.Price ,Type = game.Type, Consol = game.Consol  });

        }//insert

        public IHttpActionResult update([FromBody]Game game)
        {
            GameBussines busi = new GameBussines();
            busi.updateGame(game);
            String json = JsonConvert.SerializeObject(game.ToString());
            return Json(new { Name = game.Name, Price = game.Price, Type = game.Type, Consol = game.Consol });

        }//insert

        //public IHttpActionResult delete([FromBody]Game game)
        //{
        //    //GameBussines busi = new GameBussines();

        //    //busi.deleteGame(game.Id);
        //    //String json = JsonConvert.SerializeObject(game);
        //    //return Json(json);

        //}//delete

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {


        }//Put

        // DELETE api/values/5
        public void Delete(int id)
        {
        }//delete

    }//end class
}//end namespace
