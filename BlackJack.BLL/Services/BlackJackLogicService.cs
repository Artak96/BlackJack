using BlackJack.Core.Abstractions.IServices;
using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.Services
{
    public class BlackJackLogicService : IBlackJackLogicService
    {
        private readonly IHandService _handService;

        public BlackJackLogicService(IHandService handService)
        {
            _handService = handService;
        }

        public bool CheckForBlackjack(Hand hand)
        {
            var vall = _handService.CalculateHandValue(hand);
            return hand.Cards.Count == 2 &&  vall== 21;
        }

        public bool IsBust(Hand hand)
        {
            return _handService.CalculateHandValue(hand) > 21;
        }

        public bool CanSplit(Hand hand)
        {
            // Logic to check if the hand can be split (e.g., having two cards of the same value)
            // Implementation based on game rules
            return hand.Cards.Count == 2 && hand.Cards.FirstOrDefault().Value == hand.Cards.LastOrDefault().Value;
        }

        public bool CanDoubleDown(Hand hand)
        {
            // Logic to check if the hand is eligible for doubling down
            // Implementation based on game rules
            return hand.Cards.Count == 2;
        }

        public bool IsHandWinner(Hand playerHand, Hand dealerHand)
        {
            int playerValue = _handService.CalculateHandValue(playerHand);
            int dealerValue = _handService.CalculateHandValue(dealerHand); 

            if (playerValue > 21) return false; // Player busts, dealer wins
            if (dealerValue > 21) return true; // Dealer busts, player wins
            return playerValue > dealerValue; // Compare hand values
        }

        public int CalculateHandValue(Hand hand)
        {
            return _handService.CalculateHandValue(hand); ;
        }

        public void DealInitialCards(Player player, Dealer dealer)
        {
            // Logic to deal initial cards to player and dealer
            // Implementation based on game rules
        }

        public void Hit(Player player, Hand hand, List<Card> deck)
        {
            // Logic to deal one additional card to the hand
            // Implementation based on game rules
        }

        public void Stand(Player player)
        {
            // Logic for player to stand
            // Implementation based on game rules
        }

        public void Split(Player player, Hand hand, List<Card> deck)
        {
            // Logic to split the hand into two separate hands
            // Implementation based on game rules
        }

        public void DoubleDown(Player player, Hand hand, List<Card> deck)
        {
            // Logic for the player to double down
            // Implementation based on game rules
        }

        public void ResolveDealerHand(Dealer dealer, List<Card> deck)
        {
            // Logic for the dealer's turn to draw cards until reaching a certain value
            // Implementation based on game rules
        }
    }

}
