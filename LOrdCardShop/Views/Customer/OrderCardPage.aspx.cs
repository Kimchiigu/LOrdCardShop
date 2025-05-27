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
            if (Session["userRole"] == null || Session["userRole"].ToString() != "customer")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            //if (!IsCustomer()) Response.Redirect("~/Views/Guest/LoginPage.aspx");

            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            string cardName = Request.QueryString["search"];
            List<Card> cards;

            if (string.IsNullOrEmpty(cardName))
            {
                cards = CardsController.GetAllCards();
            }
            else
            {
                cards = CardsController.GetAllCardsByName(cardName);
            }

            if (cards != null && cards.Count > 0)
            {
                GV_Cards.Visible = true;
                GV_Cards.DataSource = cards;
                GV_Cards.DataBind();
                Lbl_Error.Text = string.Empty;
            }
            else
            {
                GV_Cards.Visible = false;
                Lbl_Error.Text = "No Cards Found!";
            }
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