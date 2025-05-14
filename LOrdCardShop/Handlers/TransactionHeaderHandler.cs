using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handlers
{
    public class TransactionHeaderHandler
    {
        public static int CreateTransactionHeader(int customerId)
        {
            return TransactionHeaderRepository.CreateTransactionHeader(customerId);
        }

        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return TransactionHeaderRepository.GetAllTransactionHeaders();
        }

        public static List<TransactionHeader> GetAllTransactionHeadersByUserId(int userId)
        {
            return TransactionHeaderRepository.GetAllTransactionHeadersByUserId(userId);
        }

        public static void HandleTransaction(int transactionId)
        {
            TransactionHeaderRepository.HandleTransaction(transactionId);
        }
    }
}