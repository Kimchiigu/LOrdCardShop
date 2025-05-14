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

        public static int CreateTransactionHeader(int customerId)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.CreateTransactionHeader(customerId);
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();

            return newTransactionHeader.TransactionID;
        }
    }
}