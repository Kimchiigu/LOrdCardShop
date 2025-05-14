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
        public static TransactionDetail GetTransactionDetailByHeaderId(int transactionHeaderId)
        {
            return TransactionDetailRepository.GetTransactionDetailByHeaderId(transactionHeaderId);
        }
    }
}