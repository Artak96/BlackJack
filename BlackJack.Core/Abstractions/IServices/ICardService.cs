using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IServices
{
    public interface ICardService
    {
        Task<List<Card>> GetCardsByHandId(int handId);
        Task<IEnumerable<Card>> GetAllCards();
    }
}
