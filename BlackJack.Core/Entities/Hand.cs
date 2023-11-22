using BlackJack.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Hand : BaseEntity
    {
        [Key]
        public int HandId { get; set; }
        [ForeignKey("RoundId")]
        public int RoundId { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        public HandType HandType { get; set; }
        public int TotalValue { get; set; }
        public virtual ICollection<Card> Cards { get; set; }

        public Round Round { get; set; }
        public Player Player { get; set; }
    }
}
