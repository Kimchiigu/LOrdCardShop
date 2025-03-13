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
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            string username = TB_Register_Username.Text;
            string email = TB_Register_Email.Text;
            string password = TB_Register_Password.Text;
            string confirmPassword = TB_Register_ConfirmPassword.Text;
            string gender = RB_Register_Male.Checked ? "Male" : "Female";
            string dob = Calendar_DOB.SelectedDate.ToString();
            Lbl_Error.ForeColor = System.Drawing.Color.Red;

            if (UsersController.ValidateRegister(username, email, password, confirmPassword, gender, dob))
            {
                Lbl_Error.Text = "Registration Success!";
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            else
            {
                Lbl_Error.Text = "Data is not Valid!";
            }
        }
    }
}