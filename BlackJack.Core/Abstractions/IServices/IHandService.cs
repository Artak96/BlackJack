using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IServices
{
    public interface IHandService
    {
        void AddCardToHand(Hand hand, Card card);
        int CalculateHandValue(Hand hand);
    }
}
