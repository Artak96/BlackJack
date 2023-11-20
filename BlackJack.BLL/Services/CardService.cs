using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.Core.Abstractions.IServices;
using BlackJack.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.Services
{
    public class CardService: ICardService
    {
        private readonly IBaseRepository<Card> _baseRepository;
        private readonly IBaseRepository<Hand_Card> _baseRepository1; //todo change into service 
        public CardService(IBaseRepository<Card> baseRepository, IBaseRepository<Hand_Card> baseRepository1)
        {
            _baseRepository = baseRepository;
            _baseRepository1 = baseRepository1;
        }

        public async Task<List<Card>> GetCardsByHandId(int handId)
        {
            // Assuming you have a many-to-many relationship between Hand and Card through Hand_Card
            var cards =await _baseRepository1.GetWhereAsync(hc => hc.HandId == handId);
            var result= cards.Select(hc => hc.Card).ToList();

            return result;
        }

        public async Task<IEnumerable<Card>> GetAllCards()
        {
            return await _baseRepository.GetAllAsync();
        }
    }
}
