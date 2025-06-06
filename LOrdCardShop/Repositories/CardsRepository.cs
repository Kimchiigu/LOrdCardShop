﻿using LOrdCardShop.Database;
using LOrdCardShop.Factories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class CardsRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Card> GetAllCards()
        {
            return db.Cards.ToList();
        }

        public static List<Card> GetAllCardsByName(string cardName)
        {
            return db.Cards
                .Where(c => c.CardName.Contains(cardName))
                .ToList();
        }

        public static Card GetCardById(int id)
        {
            return db.Cards.Find(id);
        }

        public static void AddCard(string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            Card newCard = CardsFactory.CreateCard(cardName, cardPrice, cardDesc, cardType, isFoil);
            db.Cards.Add(newCard);
            db.SaveChanges();
        }

        public static void UpdateCard(int cardId, string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            Card card = db.Cards.Find(cardId);
            if (card!= null)
            {
                card.CardID = cardId;
                card.CardName = cardName;
                card.CardPrice = cardPrice;
                card.CardDesc = cardDesc;
                card.CardType = cardType;
                card.isFoil = isFoil;

                db.SaveChanges();
            }
        }
        public static void DeleteCard(int cardId)
        {
            Card deletedCard = GetCardById(cardId);
            db.Cards.Remove(deletedCard);
            db.SaveChanges();
        }
    }
}