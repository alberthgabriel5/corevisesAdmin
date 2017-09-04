using Domain;
using Library;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AdministratorData {

        private MongoDatabase mongoDataB;
        

        public AdministratorData()
        {
            MongoConnection mongo = new MongoConnection();
            this.mongoDataB = mongo.MongoDBase;
            
        }//constructor vacio

        public void insertAdmi(Administrator admi){

            MongoCollection colleccion = this.mongoDataB.GetCollection<Administrator>("administrator");
            colleccion.Insert(admi);

        }//insertAdmi

        public int initSesssion(Administrator admi){
           
            var collection = this.mongoDataB.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = this.mongoDataB.GetCollection<Administrator>("administrator");
            var administrator = admis.FindAll();
            foreach (var item in administrator)
            {
                if (item.Password == admi.Password && item.User == admi.User) { 
                    return 1;
                }

            }//foreach
            return 0;
        }//initSession

        public Administrator initSesssionAndroid(Administrator admi)
        {

            var collection = this.mongoDataB.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = this.mongoDataB.GetCollection<Administrator>("administrator");
            var administrator = admis.FindAll();
            foreach (var item in administrator)
            {
                if (item.Password == admi.Password && item.User == admi.User)
                {
                    return item;
                }

            }//foreach
            return null;
        }//initSessionAndroid

        public List<Administrator> administrators()
        {
            
            List<Administrator> adminis = new List<Administrator>();
            var collection = this.mongoDataB.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = this.mongoDataB.GetCollection<Administrator>("administrator");
            var administrator = admis.FindAll();
            foreach (var item in administrator)
            {
                adminis.Add(item);

            }//foreach



            return adminis;

        }//adminisitrators

        public void updateAdmi(Administrator admi)
        {

            
            var query = Query<Administrator>.EQ(a => a.User, admi.User);
            var user = Update<Administrator>.Set(a => a.User, admi.User);
            var password = Update<Administrator>.Set(a => a.Password, admi.Password);
            MongoCollection colleccion = this.mongoDataB.GetCollection<Administrator>("administrator");
            colleccion.Update(query, user);
            colleccion.Update(query, password);

        }//updateAdmi

        public void deleteAdmi(String user)
        {
            var collection = this.mongoDataB.GetCollection<Administrator>("administrator");
            MongoCollection<Administrator> admis = this.mongoDataB.GetCollection<Administrator>("administrator");
            var query = Query<Administrator>.EQ(a => a.User, user);
            admis.Remove(query);
        }//deleteAdmi

    }//end class

   

}//namespace
