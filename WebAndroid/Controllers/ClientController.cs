using Business;
using Domain;
using Newtonsoft.Json;
using System;
using System.Web.Http;

namespace WebAndroid.Controllers
{
    public class ClientController : ApiController
    {
        public IHttpActionResult GetClient()
        {
            ClientBussines busi = new ClientBussines();
            string json = JsonConvert.SerializeObject(busi.clients());
            return Json(busi.clients());
        }//Get

        public IHttpActionResult initSession([FromBody]Client client)
        {
            ClientBussines busi = new ClientBussines();
            client = busi.initSessionAndroid(client.Email, client.Password);
            String jsonresp = JsonConvert.SerializeObject(client);
            return Json(new { Id=client.Id, Name = client.Name, Email = client.Email , Birthday = client.Birthday, Password = client.Password});

        }//initSession


        public IHttpActionResult insert([FromBody]Client client)
        {
            ClientBussines busi = new ClientBussines();
            busi.insertClient(client);
            String json = JsonConvert.SerializeObject(client);
            return Json(new { Id = client.Id, Name = client.Name, Email = client.Email, Birthday = client.Birthday, Password = client.Password });

        }//insert

        public IHttpActionResult update([FromBody]Client client)
        {
            ClientBussines busi = new ClientBussines();
            busi.updateClient(client);
            String json = JsonConvert.SerializeObject(client);
            return Json(new { Id = client.Id, Name = client.Name, Email = client.Email, Birthday = client.Birthday, Password = client.Password });


        }//insert

        public IHttpActionResult delete([FromBody]Client client)
        {
            ClientBussines busi = new ClientBussines();
            busi.deletClient(client);
            String json = JsonConvert.SerializeObject(client);
            return Json(new {Id=client.Id, Name = client.Name, Email = client.Email, Birthday = client.Birthday, Password = client.Password });


        }//delete

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {


        }//Put

        // DELETE api/values/5
        public void Delete(int id)
        {
        }//delete
    }
}
