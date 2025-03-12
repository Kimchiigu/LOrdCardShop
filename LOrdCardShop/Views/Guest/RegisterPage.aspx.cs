using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~Views/Guest/LoginPage.aspx");
        }
    }
}