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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            string role = Session["userRole"]?.ToString();
            int userId = Convert.ToInt32(Session["userId"]);

            List<TransactionHeader> transactions = role == "admin"
                ? TransactionHeaderController.GetAllTransactionHeaders()
                : TransactionHeaderController.GetAllTransactionHeadersByUserId(userId);

            GV_Transactions.DataSource = transactions;
            GV_Transactions.DataBind();
        }

        protected void GV_Transactions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetail")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"TransactionDetailPage.aspx?transactionId={transactionId}");
            }
        }
    }
}