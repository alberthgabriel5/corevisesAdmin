using Library;
using Domain;
using MongoDB.Driver;


namespace Data
{
    public class PurchaseData
    {
        private MongoDatabase mongoDataB;
        private MongoCollection colleccion;

        public PurchaseData()
        {
            MongoConnection mongo = new MongoConnection();
            this.mongoDataB = mongo.MongoDBase;
            this.colleccion = this.mongoDataB.GetCollection<Purchase>("purchase");
            
        }
        public void createPurchase(Purchase purchase )
        {
            colleccion.Insert(purchase);
        }
        
        public void retrivePurchase()
        {
             colleccion.FindAllAs<Purchase>();
        }

        public void deletePurchase(Purchase purchase)
        {
            //colleccion.FindAndRemove();
        }


    }
}
