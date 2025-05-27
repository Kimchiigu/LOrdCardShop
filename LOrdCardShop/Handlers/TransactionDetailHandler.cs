using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handlers
{
    public class TransactionDetailHandler
    {
        public static List<TransactionDetail> GetTransactionDetailsByHeaderId(int transactionHeaderId)
        {
            return TransactionDetailRepository.GetTransactionDetailsByHeaderId(transactionHeaderId);
        }

        public static void CreateTransactionDetail(int transactionId, int cardId, int quantity)
        {
            TransactionDetailRepository.CreateTransactionDetail(transactionId, cardId, quantity);
        }
    }
}