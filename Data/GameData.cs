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
    public class GameData
    {

        private MongoDatabase db;
    
        public GameData()
        {
            MongoConnection mongo = new MongoConnection();
            this.db = mongo.MongoDBase;
        }//constructor

        public void insertGame(Game game)
        {         
               
           MongoCollection colleccion = db.GetCollection<Game>("game");
           colleccion.Insert(game);
            
        }//insertGame

        public void updateGame(Game game)
        {
             
            var query = Query<Game>.EQ(g => g.Id, game.Id);
            var name = Update<Game>.Set(g=> g.Name, game.Name);
            var tipo = Update<Game>.Set(g => g.Type, game.Type);
            MongoCollection colleccion = db.GetCollection<Game>("game");
            colleccion.Update(query, name);
            colleccion.Update(query, tipo);
        }//updateGame

        public void delete(String id)
        {
            var collection = db.GetCollection<Game>("game");
            MongoCollection<Game> games = db.GetCollection<Game>("game");
            var query = Query<Game>.EQ(g => g.IdGame, id);
            games.Remove(query);
        }//delete

        public List<Game> allGames()
        {           
            List<Game> games = new List<Game>();
            var collection = db.GetCollection<Game>("game");
            MongoCollection<Game> allCollection = db.GetCollection<Game>("game");
            var sgames = allCollection.FindAll();
            foreach (var item in sgames)
            {
                games.Add(item);

            }//foreach

            return games;

        }//allGames

    }//end class
}//end namespace
