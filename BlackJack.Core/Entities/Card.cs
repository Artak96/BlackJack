using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Card:BaseEntity
    {
        public Card()
        {
            this.Hands = new HashSet<Hand>();
        }
        public int Id { get; set; }
        public string Suit { get; set; }
        public string Value { get; set; }
        public string Face { get; set; }
        public string Rank { get; set; }
        public bool IsFaceUp { get; set; }
        public virtual ICollection<Hand> Hands { get; set; }
    }
}
