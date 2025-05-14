using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int customerId)
        {
            TransactionHeader newTransactionHeader = new TransactionHeader
            {
                TransactionDate = DateTime.Now,
                CustomerID = customerId,
                Status = "unhandled"
            };
            return newTransactionHeader;
        }
    }
}