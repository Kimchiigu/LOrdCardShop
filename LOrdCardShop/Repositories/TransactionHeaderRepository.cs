using LOrdCardShop.Database;
using LOrdCardShop.Factories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class TransactionHeaderRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }

        public static List<TransactionHeader> GetAllTransactionHeadersByUserId(int userId)
        {
            return db.TransactionHeaders.Where(th => th.CustomerID == userId).ToList();
        }

        public static int CreateTransactionHeader(int customerId)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.CreateTransactionHeader(customerId);
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();

            return newTransactionHeader.TransactionID;
        }

        public static void HandleTransaction(int transactionId)
        {
            TransactionHeader transactionHeader = db.TransactionHeaders.Find(transactionId);
            if (transactionHeader != null)
            {
                transactionHeader.Status = "handled";
                db.SaveChanges();
            }
        }
    }
}