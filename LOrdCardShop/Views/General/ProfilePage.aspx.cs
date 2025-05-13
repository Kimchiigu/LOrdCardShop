using LOrdCardShop.Controllers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views.General
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userId"] == null) Response.Redirect("~/Views/Guest/LoginPage.aspx");

                int userId = Convert.ToInt32(Session["userId"]);
                var user = UsersController.GetUserById(userId);

                TB_Username.Text = user.UserName;
                TB_Email.Text = user.UserEmail;
                DDL_Gender.SelectedValue = user.UserGender;
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["userId"]);
            User user = new User
            {
                UserID = userId,
                UserName = TB_Username.Text.Trim(),
                UserEmail = TB_Email.Text.Trim(),
                UserGender = DDL_Gender.SelectedValue
            };

            string oldPassword = TB_OldPassword.Text;
            string newPassword = TB_NewPassword.Text;
            string confirmPassword = TB_ConfirmPassword.Text;

            string result = UsersController.UpdateProfile(user, oldPassword, newPassword, confirmPassword);

            if (string.IsNullOrEmpty(result))
            {
                LblError.ForeColor = System.Drawing.Color.Green;
                LblError.Text = "Profile updated successfully.";
            }
            else
            {
                LblError.ForeColor = System.Drawing.Color.Red;
                LblError.Text = result;
            }
        }
    }
}