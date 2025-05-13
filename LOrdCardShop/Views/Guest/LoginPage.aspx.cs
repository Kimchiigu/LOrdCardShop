using LOrdCardShop.Controllers;
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
            if ((Session["userId"] != null && Session["userRole"] != null) || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/General/HomePage.aspx");
                return;
            }
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = TB_Login_Username.Text;
            string password = TB_Login_Password.Text;
            bool rememberMe = CB_RememberMe.Checked;
            Lbl_Error.ForeColor = System.Drawing.Color.Red;

            string loginValidation = UsersController.ValidateLogin(username, password, rememberMe);

            if (string.IsNullOrEmpty(loginValidation))
            {
                Lbl_Error.ForeColor = System.Drawing.Color.Green;
                Lbl_Error.Text = "Login Success!";
                Response.Redirect("~/Views/General/HomePage.aspx");
            }
            else
            {
                Lbl_Error.Text = loginValidation;
            }
        }
    }
}