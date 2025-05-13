using LOrdCardShop.Database;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class CardsRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Card> GetAllCards()
        {
            return db.Cards.ToList();
        }

        public static Card GetCardById(int id)
        {
            return db.Cards.Find(id);
        }
    }
}