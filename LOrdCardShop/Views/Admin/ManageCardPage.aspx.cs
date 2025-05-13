using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrdCardShop.Model;
using LOrdCardShop.Repositories;

namespace LOrdCardShop.Views.Admin
{
    public partial class ManageCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }
        }

        protected void refreshGrid()
        {
            List<Card> cards = CardsRepository.GetAllCards();

            if (cards != null && cards.Count > 0)
            {
                cardGV.Visible = true;
                cardGV.DataSource = cards;
                cardGV.DataBind();
                ErrorLbl.Text = string.Empty;
            }
            else
            {
                cardGV.Visible = false;
                ErrorLbl.Text = "No Cards Found!";
            }

        }

        protected void cardGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = cardGV.Rows[e.NewEditIndex];
            int cardId = int.Parse(row.Cells[0].Text);

            cardGV.EditIndex = -1;
            Response.Redirect("~/Views/Admin/UpdateCardPage.aspx?CardID=" + cardId);
        }

        protected void cardGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = cardGV.Rows[e.RowIndex];
            int cardId = int.Parse(row.Cells[0].Text);

            CardsRepository.DeleteCard(cardId);

            cardGV.EditIndex = -1;
            refreshGrid();
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/AddCardPage.aspx");
        }
    }
}