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
            if (!IsPostBack && Request.QueryString["transactionId"] != null)
            {
                int transactionId = Convert.ToInt32(Request.QueryString["transactionId"]);
                TransactionDetail details = TransactionDetailController.GetTransactionDetailByHeaderId(transactionId);
                GV_Details.DataSource = new List<TransactionDetail> { details };
                GV_Details.DataBind();
            }
        }
    }
}