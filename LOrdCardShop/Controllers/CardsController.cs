using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class CardsController
    {
        public static List<Card> GetAllCards()
        {
            return CardsHandler.GetAllCards();
        }

        public static List<Card> GetAllCardsByName(string cardName)
        {
            return CardsHandler.GetAllCardsByName(cardName);
        }

        public static Card GetCardById(int id)
        {
            return CardsHandler.GetCardById(id);
        }

        public static string AddCard(string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            if (!ValidateName(cardName))
                return "Name must be 5-50 characters and contain only letters and spaces.";

            if (!ValidatePrice(cardPrice))
                return "Price must be at least 10000.";

            if (!ValidateDescription(cardDesc))
                return "Description must not be empty.";

            if (!ValidateType(cardType))
                return "Type must be 'Spell' or 'Monster'.";

            if (!ValidateFoil(isFoil))
                return "Foil must be true or false.";

            CardsHandler.AddCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            return string.Empty;
        }

        public static string UpdateCard(Card updatedCard)
        {
            if (!ValidateName(updatedCard.CardName))
                return "Name must be 5-50 characters and contain only letters and spaces.";

            if (!ValidatePrice(updatedCard.CardPrice))
                return "Price must be at least 10000.";

            if (!ValidateDescription(updatedCard.CardDesc))
                return "Description must not be empty.";

            if (!ValidateType(updatedCard.CardType))
                return "Type must be 'Spell' or 'Monster'.";

            if (!ValidateFoil(updatedCard.isFoil))
                return "Foil must be true or false.";

            CardsHandler.UpdateCard(updatedCard);
            return string.Empty;
        }

        private static bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 5 || name.Length > 50)
                return false;

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }

            return true;
        }

        private static bool ValidatePrice(double price)
        {
            return price >= 10000;
        }

        private static bool ValidateDescription(string desc)
        {
            return !string.IsNullOrWhiteSpace(desc);
        }

        private static bool ValidateType(string type)
        {
            return type == "Spell" || type == "Monster";
        }

        private static bool ValidateFoil(bool isFoil)
        {
            return isFoil == true || isFoil == false;
        }
    }
}