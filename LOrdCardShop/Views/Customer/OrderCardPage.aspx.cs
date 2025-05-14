using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
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
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            List<Card> cards = CardsController.GetAllCards();
            GV_Cards.DataSource = cards;
            GV_Cards.DataBind();
        }

        protected void GV_Cards_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int cardId = Convert.ToInt32(e.CommandArgument);
            int userId = Convert.ToInt32(Session["userId"]);
            int rowIndex = ((GridViewRow)((Control)e.CommandSource).NamingContainer).RowIndex;

            int quantity = 1;

            if (GV_Cards.Rows[rowIndex].FindControl("TB_Quantity") is TextBox tbQuantity && int.TryParse(tbQuantity.Text, out int parsedQty))
            {
                quantity = Math.Max(1, parsedQty);
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