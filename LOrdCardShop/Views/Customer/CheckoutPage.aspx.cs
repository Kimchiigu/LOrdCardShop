using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Customer
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        public double TotalPrice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "customer")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                int userId = Convert.ToInt32(Session["UserId"]);
                RefreshGrid(userId);
            }
        }

        protected void RefreshGrid(int userId)
        {
            List<Cart> carts = CartsRepository.GetAllCartsByUserId(userId);
            List<Card> cards = new List<Card>();
            TotalPrice = carts.Sum(c => c.Card.CardPrice * c.Quantity);

            foreach (Cart cart in carts)
            {
                Card card = CardsController.GetCardById(cart.CardID);
                if (card != null)
                {
                    cards.Add(card);
                }
            }

            if (cards != null && cards.Count > 0)
            {
                GV_Cart.Visible = true;
                GV_Cart.DataSource = cards;
                GV_Cart.DataBind();
                Lbl_Error.Text = string.Empty;
                
            }
            else
            {
                GV_Cart.Visible = false;
                Lbl_Error.Text = "No Cards Found!";
            }
        }

        protected void Btn_Checkout_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            string errorMessage = TransactionHeaderController.Checkout(userId);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Lbl_Error.Text = errorMessage;
                return;
            }
            else
            {
                Lbl_Error.Text = "Checkout Successful!";
                Response.Redirect("~/Views/Customer/CartPage.aspx");
            }
        }
    }
}