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
            TransactionCrystalReport report = new TransactionCrystalReport();
            CrystalReportViewer1.ReportSource = report;
        }
    }
}