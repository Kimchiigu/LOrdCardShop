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
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userId = Convert.ToInt32(Session["userId"]);
                RefreshGrid(userId);
            }
        }

        protected void RefreshGrid(int userId)
        {
            List<Cart> carts = CartsRepository.GetAllCartsByUserId(userId);
            List<Card> cards = new List<Card>(); 

            foreach (Cart cart in carts)
            {
                Card card = CardsRepository.GetCardById(cart.CardID);
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
            Response.Redirect("~/Views/Customer/CheckoutPage.aspx");
        }

        protected void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (GV_Cart.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(Session["userId"]);
                CartsController.ClearCart(userId);
                RefreshGrid(userId);
            }
            else
            {
                Lbl_Error.Text = "No Cards Found!";
            }
        }
    }
}