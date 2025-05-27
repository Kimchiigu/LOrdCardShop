using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Admin
{
    public partial class AddCardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                Lbl_Error.Visible = false;
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            string cardName = TB_AddCard_Name.Text.Trim().ToString();
            double cardPrice = double.Parse(TB_AddCard_Price.Text.Trim().ToString());
            string cardDesc = TB_AddCard_Desc.Text.Trim().ToString();
            string cardType = DDL_AddCard_Type.SelectedValue.ToString();
            bool isFoil = CB_AddCard_Foil.Checked;

            string result = CardsController.AddCard(cardName, cardPrice, cardDesc, cardType, isFoil);

            Lbl_Error.Visible = true;

            if (string.IsNullOrEmpty(result))
            {
                Lbl_Error.ForeColor = System.Drawing.Color.Green;
                Lbl_Error.Text = "Card added successfully.";
                Response.Redirect("~/Views/Admin/ManageCardPage.aspx");
            }
            else
            {
                Lbl_Error.ForeColor = System.Drawing.Color.Red;
                Lbl_Error.Text = result;
            }
        }
    }
}