using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Hand
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int PlayerId { get; set; }
        public string HandType { get; set; }
        public int TotalValue { get; set;}

    }
}
