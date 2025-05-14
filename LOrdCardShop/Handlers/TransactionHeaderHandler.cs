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
    }
}