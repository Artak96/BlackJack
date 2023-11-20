using BlackJack.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Card
    {
         public Card()
        {
            this.Hands = new HashSet<Hand>();
        }
        [Key]
        public int CardId { get; set; }
        public int Value { get; set; }
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
        public bool IsFaceUp { get; set; }

    }
}
