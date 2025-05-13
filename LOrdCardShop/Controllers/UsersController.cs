using LOrdCardShop.Handlers;
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

            HttpContext.Current.Session["userId"] = currentUser.UserID;
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
        public static List<Card> GetFeaturedCards()
        {
            return UsersHandler.GetFeaturedCards();
        }

        public static string AddToCart(int userId, int cardId, int quantity)
        {
            return UsersHandler.AddToCart(userId, cardId, quantity);
        }
    }
}
