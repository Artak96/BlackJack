using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Prize: BaseEntity
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
    }
}
