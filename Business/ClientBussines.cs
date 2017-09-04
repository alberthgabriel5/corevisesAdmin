using Data;
using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class ClientBussines
    {
        private ClientData clienData;
        public ClientBussines()
        {
            this.clienData = new ClientData();
        }//constructor

        public List<Client> clients()
        {
            return clienData.clients();
        }

        public void insertClient(Client client)
        {
            this.clienData.insertClient(client);
        }//insertClient

        public void updateClient(Client client)
        {
            this.clienData.updateClient(client);
        }//updateClient

        public void deletClient(String email)
        {
            this.clienData.deleteClient(email);
        }//deleClient

        public int initSession(string email,string pass)
        {
            return this.clienData.initSesssion(email,pass);
        }//initSession

        public Client initSessionAndroid(string email, string pass)
        {
            return this.clienData.initSessionAndroid(email, pass);
        }//initSession

    }//end class
}//end namespace
