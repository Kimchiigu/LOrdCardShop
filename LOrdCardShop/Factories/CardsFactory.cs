using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factories
{
    public class CardsFactory
    {
        public static Card CreateCard(string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            Card card = new Card
            {
                CardName = cardName,
                CardPrice = cardPrice,
                CardDesc = cardDesc,
                CardType = cardType,
                isFoil = isFoil
            };
            return card;
        }
    }
}