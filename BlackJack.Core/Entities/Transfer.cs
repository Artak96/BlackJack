using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Transfer: BaseEntity
    {
        public int Id { get; set; }
        public int FromPlayerId { get; set; } 
        public int ToPlayerId { get; set; } 
        public decimal Amount { get; set; }
        public DateTime TransferTime { get; set; }
    }
}
