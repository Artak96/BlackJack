using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Hand_Card:BaseEntity
    {
        [ForeignKey("CardId")]
        public int CardId { get; set; }
        [ForeignKey("HandId")]
        public int HandId { get; set; }
        public bool IsFace { get; set; }
        public Card Card { get; set; }
        public Hand Hand { get; set; }
    }
}
