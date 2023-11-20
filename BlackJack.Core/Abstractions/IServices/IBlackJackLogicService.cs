using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IServices
{
    public interface IBlackJackLogicService
    {
        bool CheckForBlackjack(Hand hand);
        bool IsBust(Hand hand);
        bool CanSplit(Hand hand);
        bool CanDoubleDown(Hand hand);
        bool IsHandWinner(Hand playerHand, Hand dealerHand);
        int CalculateHandValue(Hand hand);
        void DealInitialCards(Player player, Dealer dealer);
        void Hit(Player player, Hand hand, List<Card> deck);
        void Stand(Player player);
        void Split(Player player, Hand hand, List<Card> deck);
        void DoubleDown(Player player, Hand hand, List<Card> deck);
        void ResolveDealerHand(Dealer dealer, List<Card> deck);
    }
}
