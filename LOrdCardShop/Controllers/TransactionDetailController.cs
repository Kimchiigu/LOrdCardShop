using LOrdCardShop.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class TransactionDetailController
    {
        public static void CreateTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetailHandler.CreateTransactionDetail(transactionId, cardId, quantity);
        }
    }
}