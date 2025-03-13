using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = TB_Login_Username.Text;
            string password = TB_Login_Password.Text;
            bool rememberMe = CB_RememberMe.Checked;

            if (rememberMe)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Value = username;
                cookie.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(cookie);
            }
        }
    }
}