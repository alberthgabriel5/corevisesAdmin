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
    public class ClientData
    {

        private MongoDatabase mongoDataB;
        private MongoCollection colleccion;

        public ClientData()
        {
            MongoConnection mongo = new MongoConnection();
            this.mongoDataB = mongo.MongoDBase;
            this.colleccion = this.mongoDataB.GetCollection<Client>("client");
        }//constructor vacio

        public void insertClient(Client client)
        {                          
                this.colleccion.Insert(client);  
        }//insertCLient

        public int initSesssion(string email, string pass)
        {

            MongoCollection<Client> clients = this.mongoDataB.GetCollection<Client>("client");
            var clientes = clients.FindAll();
            foreach (var item in clientes)
            {
                if (item.Email == email && item.Password == pass)
                {
                    return 1;
                }

            }//foreach
            return 0;
        }//initSession

        public Client initSessionAndroid(string email, string pass)
        {

            MongoCollection<Client> clients = this.mongoDataB.GetCollection<Client>("client");
            var clientes = clients.FindAll();
            foreach (var item in clientes)
            {
                if (item.Email == email && item.Password == pass)
                {
                    return item;
                }

            }//foreach
            return null;
        }//initSession



        public List<Client> clients()
        {
            
            List<Client> clients = new List<Client>();
            var collection = this.mongoDataB.GetCollection<Client>("client");
            MongoCollection<Client> allCollection = this.mongoDataB.GetCollection<Client>("client");
            var sclients = allCollection.FindAll();
            foreach(var item in sclients)
            {
                clients.Add(item);

            }//foreach

            return clients;

        }//CLients

        public void updateClient(Client client)
        {
                var query = Query<Client>.EQ(c => c.Email, client.Email);
                var user = Update<Client>.Set(c => c.Email, client.Email);
                var password = Update<Client>.Set(c => c.Password, client.Password);
                MongoCollection colleccion = this.mongoDataB.GetCollection<Client>("client");
                colleccion.Update(query, user);
                colleccion.Update(query, password);
        }//updateCLient

        public void deleteClient(String id)
        {
            ObjectId idN = new ObjectId(id);
            var collection = this.mongoDataB.GetCollection<Client>("client");
            MongoCollection<Client> clients = this.mongoDataB.GetCollection<Client>("client");
            var query = Query<Client>.EQ(c => c.Id, idN);
            clients.Remove(query);

        }//deleteClient
    }//end class
}//end namespace
