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
    public class AdmiController : ApiController
    {
        public IHttpActionResult GetAdmis()
        {
            AdministratorBussines busi = new AdministratorBussines();
            return Json(busi.administrator());
        }//Get

        public IHttpActionResult initSession([FromBody]Administrator admi)
        {
            AdministratorBussines busi = new AdministratorBussines();
            admi = busi.initSessionAndroid(admi);
            var json = JsonConvert.SerializeObject(admi);
            return Json(new { Id = admi.Id, User = admi.User, Password = admi.Password });

        }//initSessionAndroid

        public IHttpActionResult insert([FromBody]Administrator admi)
        {
            AdministratorBussines busi = new AdministratorBussines();
            busi.insertAdmi(admi);
            string json = JsonConvert.SerializeObject(admi);
            return Json(new { Id = admi.Id, User = admi.User, Password = admi.Password });

        }//insert

        public IHttpActionResult update([FromBody]Administrator admi)
        {
            AdministratorBussines busi = new AdministratorBussines();
            busi.updateAdmi(admi);
            String json = JsonConvert.SerializeObject(admi);
            return Json(new {Id=admi.Id, User = admi.User, Password = admi.Password });

        }//insert

        public IHttpActionResult delete([FromBody]Administrator admi)
        {
            AdministratorBussines busi = new AdministratorBussines();
            busi.deleteAdmi(admi.User);
            String json = JsonConvert.SerializeObject(admi);
            return Json(new { Id = admi.Id, User = admi.User, Password = admi.Password });

        }//delete

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {


        }//Put

        // DELETE api/values/5
        public void Delete(int id)
        {
        }//delete

    }//end class
}
