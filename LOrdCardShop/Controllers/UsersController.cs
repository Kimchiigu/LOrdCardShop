using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;

namespace LOrdCardShop.Controllers
{
    public class UsersController
    {
        public static bool ValidateLogin(string username, string password)
        {
            if (ValidateUsername(username) && ValidatePassword(password))
            {
                return true;
            }

            return false;
        }

        public static bool ValidateRegister(string username, string email, string password, string confirmPassword, string gender, string dob)
        {
            if (ValidateUsername(username) && ValidateEmail(email) && ValidatePassword(password) && ValidateConfirmPassword(password, confirmPassword) && ValidateGender(gender) && ValidateDOB(dob))
            {
                UsersHandler.AddUser(username, email, password, gender, dob);
                return true;
            }

            return false;
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
