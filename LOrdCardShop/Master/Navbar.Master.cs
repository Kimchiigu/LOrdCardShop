using LOrdCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Master
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        public string Username { get; private set; } = "Guest";
        public string UserRole { get; private set; } = "Guest";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Url.AbsolutePath.Contains("LoginPage.aspx"))
            {
                return; 
            }

            if (Session["userId"] == null && Session["userRole"] == null && Session["username"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
                return;
            }

            if (Session["username"] != null)
            {
                int id = Convert.ToInt32(Session["userId"]);
                Username = UsersController.GetUsernameById(id);
            }


            if (Session["userRole"] != null)
            {
                UserRole = Session["userRole"].ToString();
            }

            RenderNavbar(UserRole);
        }

        private void RenderNavbar(string role)
        {
            CustomerNav.Visible = (role == "customer");
            AdminNav.Visible = (role == "admin");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            UsersController.Logout();
            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }

        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = TB_Search.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                return;
            }

            string role = Session["userRole"]?.ToString() ?? "";

            if (role == "admin")
            {
                Response.Redirect($"~/Views/Admin/ManageCardPage.aspx?search={HttpUtility.UrlEncode(searchKeyword)}");
            }
            else if (role == "customer")
            {
                Response.Redirect($"~/Views/Customer/OrderCardPage.aspx?search={HttpUtility.UrlEncode(searchKeyword)}");
            }
        }
    }
}