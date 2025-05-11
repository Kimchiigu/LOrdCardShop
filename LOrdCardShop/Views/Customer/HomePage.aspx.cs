using LOrdCardShop.Model;
using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Customer
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Card> featuredCards = UsersController.GetFeaturedCards();
                CardRepeater.DataSource = featuredCards;
                CardRepeater.DataBind();
            }
        }

        protected void CardRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int cardId = Convert.ToInt32(e.CommandArgument);
                int userId = Convert.ToInt32(Session["UserID"]);
                string result = UsersController.AddToCart(userId, cardId, 1);
                //lblMessage.Text = result;
            }
        }
    }
}