using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace LOrdCardShop.Views.Admin
{
    public partial class OrderQueuePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "admin")
            {
                Response.Redirect("~/Views/General/HomePage.aspx");
            }

            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            List<TransactionHeader> transactionHeaders = TransactionHeaderController.GetAllTransactionHeaders();
            GV_Transactions.DataSource = transactionHeaders;
            GV_Transactions.DataBind();
        }

        protected void GV_Transactions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "HandleStatus")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);

                int rowIndex = ((GridViewRow)((Control)e.CommandSource).NamingContainer).RowIndex;

                string status = GV_Transactions.Rows[rowIndex].Cells[2].Text;

                if (status.ToLower() == "unhandled")
                {
                    TransactionHeaderController.HandleTransaction(transactionId);
                    RefreshGrid();
                }
            }
        }
    }
}