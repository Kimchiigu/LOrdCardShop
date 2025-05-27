using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.General
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            if (!IsPostBack && Request.QueryString["transactionId"] != null)
            {
                int transactionId = Convert.ToInt32(Request.QueryString["transactionId"]);
                List<TransactionDetail> details = TransactionDetailController.GetTransactionDetailsByHeaderId(transactionId);
                GV_Details.DataSource = details;
                GV_Details.DataBind();
            }
        }

        protected double grandTotal = 0;

        protected void GV_Details_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                double price = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "Card.CardPrice"));
                int quantity = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Quantity"));
                grandTotal += price * quantity;
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lblGrandTotal = (Label)e.Row.FindControl("lblGrandTotal");
                if (lblGrandTotal != null)
                {
                    lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString("F2");
                    lblGrandTotal.Font.Bold = true;
                }
            }
        }
    }
}