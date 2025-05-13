using System;
using System.Data.SqlClient;
using System.Linq;
using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using LOrdCardShop.Repositories;

namespace LOrdCardShop.Views.Admin
{
    public partial class UpdateCardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                        CardTypeTxt.Text = card.CardType;
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
            decimal cardPrice = decimal.Parse(CardPriceTxt.Text);
            string cardDesc = CardDescTxt.Text.Trim();
            string cardType = CardTypeTxt.Text.Trim();
            bool isFoil = IsFoilChk.Checked;

            Card updatedCard = new Card
            {
                CardID = cardId,
                CardName = cardName,
                CardPrice = (double)cardPrice,
                CardDesc = cardDesc,
                CardType = cardType,
                isFoil = isFoil,
            };

            string result = CardsController.UpdateCard(updatedCard);

            if (string.IsNullOrEmpty(result))
            {
                lblError.ForeColor = System.Drawing.Color.Green;
                lblError.Text = "Card updated successfully.";
            }
            else
            {
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = result;
            }
        }

    }
}
