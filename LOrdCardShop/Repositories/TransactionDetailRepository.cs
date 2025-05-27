using LOrdCardShop.Database;
using LOrdCardShop.Factories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class TransactionDetailRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionDetail> GetTransactionDetailsByHeaderId(int headerId)
        {
            return db.TransactionDetails
                     .Where(td => td.TransactionID == headerId)
                     .ToList();
        }

        public static void CreateTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetail newTransactionDetail = TransactionDetailFactory.CreateTransactionDetail(transactionId, cardId, quantity);
            db.TransactionDetails.Add(newTransactionDetail);
            db.SaveChanges();
        }
    }
}