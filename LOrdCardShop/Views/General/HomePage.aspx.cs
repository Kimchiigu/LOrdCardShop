using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.Customer
{
    public partial class HomePage : System.Web.UI.Page
    {
        public string Username { get; private set; } = "Guest";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }

            if (Session["username"] != null)
            {
                Username = Session["username"].ToString();
            }
        }
    }
}