﻿using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Xml.Linq;

namespace LOrdCardShop.Controllers
{
    public class UsersController
    {
        public static void Logout()
        {
            HttpContext.Current.Session["userId"] = null;
            HttpContext.Current.Session["username"] = null;
            HttpContext.Current.Session["userRole"] = null;

            HttpCookie userCookie = HttpContext.Current.Request.Cookies["user_cookie"];
            if (userCookie != null)
            {
                userCookie.Values["name"] = null;
                userCookie.Values["password"] = null;
                userCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }

            HttpContext.Current.Session.Remove("userId");
            HttpContext.Current.Session.Remove("username");
            HttpContext.Current.Session.Remove("userRole");
        }

        public static string UpdateProfile(int userId, string username, string userEmail, string userGender, string oldPassword, string newPassword, string confirmPassword)
        {
            if (!ValidateUsername(username))
                return "Username must be 5-30 letters only (letters and spaces allowed).";

            if (!ValidateEmail(userEmail))
                return "Email must contain '@' and not be empty.";

            if (!ValidateGender(userGender))
                return "Please select a valid gender.";

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (!ValidatePassword(newPassword))
                    return "New password must be at least 8 characters and alphanumeric.";

                if (newPassword != confirmPassword)
                    return "Confirmation password does not match.";

                var existingUser = UsersHandler.GetUserById(userId);
                if (existingUser == null || existingUser.UserPassword != oldPassword)
                    return "Old password is incorrect.";

                UsersHandler.UpdateUserWithPassword(userId, username, userEmail, userGender, newPassword);
            }
            else
            {
                UsersHandler.UpdateUserWithoutPassword(userId, username, userEmail, userGender);
            }

            return string.Empty;
        }

        public static string ValidateLogin(string username, string password, bool rememberMe)
        {
            if (!ValidateUsername(username))
                return "Username must be 5-30 letters only (letters and spaces allowed).";

            if (!ValidatePassword(password))
                return "Password must be at least 8 characters, contain letters and digits.";

            User currentUser = UsersHandler.ValidateLogin(username, password);

            if (currentUser == null)
                return "Invalid credentials. Please try again";

            if (rememberMe)
            {
                HttpCookie userCookie = new HttpCookie("user_cookie")
                {
                    Values = { ["username"] = username, ["password"] = password },
                    Expires = DateTime.Now.AddHours(1)
                };
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }

            HttpContext.Current.Session["username"] = currentUser.UserName.ToString();
            HttpContext.Current.Session["userId"] = currentUser.UserID.ToString();
            HttpContext.Current.Session["userRole"] = currentUser.UserRole.ToString();

            return string.Empty;
        }

        public static string ValidateRegister(string username, string email, string password, string confirmPassword, string gender, string dob)
        {
            if (!ValidateUsername(username))
                return "Username must be 5-30 letters only (letters and spaces allowed).";

            if (!ValidateEmail(email))
                return "Email must contain '@' and not be empty.";

            if (!ValidatePassword(password))
                return "Password must be at least 8 characters, contain letters and digits.";

            if (!ValidateConfirmPassword(password, confirmPassword))
                return "Password confirmation does not match.";

            if (!ValidateGender(gender))
                return "Please select a valid gender.";

            if (!ValidateDOB(dob))
                return "You must be at least 17 years old.";

            UsersHandler.AddUser(username, email, password, gender, dob);
            return string.Empty;
        }


        private static bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 30)
            {
                return false;
            }

            foreach (char c in username)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return email.Contains("@");
        }

        private static bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                return false;
            }

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (hasLetter && hasDigit)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ValidateConfirmPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        private static bool ValidateGender(string gender)
        {
            return gender == "Male" || gender == "Female";
        }

        private static bool ValidateDOB(string dob)
        {
            if (DateTime.TryParse(dob, out DateTime birthDate))
            {
                int age = DateTime.Today.Year - birthDate.Year;

                if (birthDate > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                return age >= 17;
            }

            return false;
        }

        public static string GetUsernameById(int id)
        {
            return UsersHandler.GetUsernameById(id);
        }

        public static User GetUserById(int id)
        {
            return UsersHandler.GetUserById(id);
        }
    }
}
