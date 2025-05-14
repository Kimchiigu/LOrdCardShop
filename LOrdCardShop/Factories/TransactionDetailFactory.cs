using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetail newTransactionDetail = new TransactionDetail
            {
                TransactionID = transactionId,
                CardID = cardId,
                Quantity = quantity
            };
            return newTransactionDetail;
        }
    }
}