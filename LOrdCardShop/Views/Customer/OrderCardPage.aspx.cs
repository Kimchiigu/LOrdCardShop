using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Customer
{
    public partial class OrderCardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCustomer()) Response.Redirect("~/Views/Guest/LoginPage.aspx");
            if (!IsPostBack)
            {
                var cards = CardsController.GetAllCards();
                RepeaterCards.DataSource = cards;
                RepeaterCards.DataBind();
            }
        }

        protected void CardCommand(object sender, CommandEventArgs e)
        {
            int cardId = int.Parse(e.CommandArgument.ToString());
            int userId = Convert.ToInt32(Session["userId"]);
            int quantity = 1;

            var button = (Button)sender;
            var item = (RepeaterItem)button.NamingContainer;
            var TB_Quantity = (TextBox)item.FindControl("TB_Quantity");

            if (TB_Quantity != null && int.TryParse(TB_Quantity.Text, out int qty))
            {
                quantity = Math.Max(1, qty);
            }

            if (e.CommandName == "AddToCart")
            {
                CartsController.AddCardToCart(cardId, userId, quantity);
            }
            else if (e.CommandName == "ViewDetail")
            {
                Response.Redirect($"/Views/Customer/CardDetailPage.aspx?cardId={cardId}");
            }
        }

        private bool IsCustomer()
        {
            return Session["userRole"]?.ToString() == "customer";
        }
    }
}