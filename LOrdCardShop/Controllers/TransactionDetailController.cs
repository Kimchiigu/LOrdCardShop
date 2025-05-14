using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
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

        public static TransactionDetail GetTransactionDetailByHeaderId(int transactionHeaderId)
        {
            return TransactionDetailHandler.GetTransactionDetailByHeaderId(transactionHeaderId);
        }
    }
}