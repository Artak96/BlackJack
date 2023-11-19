using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Mineral_Transaction
    {
        public int Id { get; set; }
        public int PrizeId { get; set; }
        public int GameId { get; set; }
        
        public int RoundId { get; set; }
        public float Quantity { get; set; }
        public DateTime TransactionTime { get; set; }
    }
}
