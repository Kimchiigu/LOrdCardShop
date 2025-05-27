using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Customer
{
    public partial class CardDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "customer")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            //if (!IsCustomer()) Response.Redirect("~/Views/Guest/Login.aspx");

            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["cardId"], out int cardId))
                {
                    var card = CardsController.GetCardById(cardId);
                    if (card != null)
                    {
                        LblName.Text = card.CardName;
                        LblPrice.Text = card.CardPrice.ToString("F2");
                        LblType.Text = card.CardType;
                        LblDesc.Text = card.CardDesc;
                    }
                }
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/OrderCardPage.aspx");
        }

        private bool IsCustomer()
        {
            return Session["userRole"]?.ToString() == "customer";
        }
    }
}