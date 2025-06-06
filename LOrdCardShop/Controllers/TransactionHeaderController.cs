﻿using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class TransactionHeaderController
    {
        public static int CreateTransactionHeader(int customerId)
        {
            return TransactionHeaderHandler.CreateTransactionHeader(customerId);
        }

        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return TransactionHeaderHandler.GetAllTransactionHeaders();
        }

        public static List<TransactionHeader> GetAllTransactionHeadersByUserId(int userId)
        {
            return TransactionHeaderHandler.GetAllTransactionHeadersByUserId(userId);
        }

        public static string Checkout(int userId)
        {
            List<Cart> cartItems = CartsHandler.GetAllCartsByUserId(userId);
            if (cartItems == null || !cartItems.Any())
                return "Cart is empty.";

            int transactionId = TransactionHeaderHandler.CreateTransactionHeader(userId);

            foreach (Cart cart in cartItems)
            {
                TransactionDetailHandler.CreateTransactionDetail(transactionId, cart.CardID, cart.Quantity);
            }

            CartsHandler.ClearCart(userId);

            return string.Empty;
        }

        public static void HandleTransaction(int transactionId)
        {
            TransactionHeaderHandler.HandleTransaction(transactionId);
        }
    }
}