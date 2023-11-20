using BlackJack.Core.Abstractions.IServices;
using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.Services
{
    public class HandService: IHandService
    {
        public void AddCardToHand(Hand hand, Card card)
        {
            // Assuming a mechanism to add a card to the hand
            // For example:
            hand.Cards.Add(card);
        }

        public int CalculateHandValue(Hand hand)
        {
            int value = 0;
            int aceCount = 0;

            foreach (var card in hand.Cards)
            {
                if (card.Rank == "Ace")
                {
                    value += 11;
                    aceCount++;
                }
                else if (card.Rank == "Jack" || card.Rank == "Queen" || card.Rank == "King")
                {
                    value += 10;
                }
                else
                {
                    // Assuming that the Value property holds the numeric value of the card
                    value += int.Parse(card.Value);
                }
            }

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }
}
