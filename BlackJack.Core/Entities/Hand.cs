using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Hand:BaseEntity
    {
        public Hand()
        {
            this.Cards = new HashSet<Card>();
        }
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int PlayerId { get; set; }
        public string HandType { get; set; }
        public int TotalValue { get; set;}
        public virtual ICollection<Card> Cards { get; set; }
    }
}
