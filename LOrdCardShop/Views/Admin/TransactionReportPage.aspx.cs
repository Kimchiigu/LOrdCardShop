using LOrdCardShop.Controllers;
using LOrdCardShop.Dataset;
using LOrdCardShop.Model;
using LOrdCardShop.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Admin
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null || Session["userRole"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }

            CrystalReportTransaction report = new CrystalReportTransaction();
            CrystalReportViewer1.ReportSource = report;
            TransactionDataSet data = GetDataSource(TransactionHeaderController.GetAllTransactionHeaders());
            report.SetDataSource(data);
        }

        private TransactionDataSet GetDataSource(List<TransactionHeader> transactions)
        {
            TransactionDataSet data = new TransactionDataSet();
            var transactionHeaderTable = data.transaction_header;
            var transactionDetailTable = data.transaction_detail;

            foreach (var transaction in transactions)
            {
                var headerRow = transactionHeaderTable.Newtransaction_headerRow();
                headerRow.transaction_id = transaction.TransactionID.ToString();
                headerRow.transaction_date = transaction.TransactionDate.ToString();
                double GrandTotal = 0;

                foreach (var detail in transaction.TransactionDetail)
                {
                    double SubTotal = 0;
                    var detailRow = transactionDetailTable.Newtransaction_detailRow();
                    detailRow.transaction_id = detail.TransactionID.ToString();
                    detailRow.card_id = detail.CardID.ToString();
                    detailRow.quantity = detail.Quantity.ToString();
                    detailRow.price = detail.Card.CardPrice.ToString();
                    SubTotal += (double)(detail.Quantity * detail.Card.CardPrice);
                    detailRow.subtotal = SubTotal.ToString();
                    GrandTotal += SubTotal;
                    transactionDetailTable.Addtransaction_detailRow(detailRow);
                }

                headerRow.grand_total = GrandTotal.ToString();
                transactionHeaderTable.Addtransaction_headerRow(headerRow);
            }

            return data;
        }
    }
}