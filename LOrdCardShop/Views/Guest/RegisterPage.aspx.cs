using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["userId"] != null && Session["userRole"] != null && Session["username"] != null) || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/General/HomePage.aspx");
                return;
            }
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            string username = TB_Register_Username.Text;
            string email = TB_Register_Email.Text;
            string password = TB_Register_Password.Text;
            string confirmPassword = TB_Register_ConfirmPassword.Text;
            string gender = RB_Register_Male.Checked ? "Male" : "Female";
            string dob = Calendar_DOB.SelectedDate.ToString();
            Lbl_Error.ForeColor = System.Drawing.Color.Red;

            string registerValidation = UsersController.ValidateRegister(username, email, password, confirmPassword, gender, dob);

            if (string.IsNullOrEmpty(registerValidation))
            {
                Lbl_Error.ForeColor = System.Drawing.Color.Green;
                Lbl_Error.Text = "Registration Success!";
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            else
            {
                Lbl_Error.Text = registerValidation;
            }
        }
    }
}