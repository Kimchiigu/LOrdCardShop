using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Admin
{
    public partial class UpdateCardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                int cardId;
                if (int.TryParse(Request.QueryString["CardID"], out cardId))
                {
                    var card = CardsController.GetCardById(cardId);
                    if (card != null)
                    {
                        CardID.Text = card.CardID.ToString();
                        CardNameTxt.Text = card.CardName;
                        CardPriceTxt.Text = card.CardPrice.ToString();
                        CardDescTxt.Text = card.CardDesc;
                        CardTypeDropdown.Text = card.CardType;
                        IsFoilChk.Checked = card.isFoil;
                    }
                    else
                    {
                        lblError.Text = "Card not found!";
                    }
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

            int cardId = int.Parse(CardID.Text);
            string cardName = CardNameTxt.Text.Trim();
            double cardPrice = double.Parse(CardPriceTxt.Text);
            string cardDesc = CardDescTxt.Text.Trim();
            string cardType = CardTypeDropdown.SelectedValue;
            bool isFoil = IsFoilChk.Checked;

            string result = CardsController.UpdateCard(cardId, cardName, cardPrice, cardDesc, cardType, isFoil);

            if (string.IsNullOrEmpty(result))
            {
                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Card updated successfully.";

                string script = "setTimeout(function() { window.location.href = '/Views/Admin/ManageCardPage.aspx'; }, 3000);";
                ClientScript.RegisterStartupScript(this.GetType(), "RedirectAfterUpdate", script, true);
            }
            else
            {
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = result;
            }
        }
    }
}