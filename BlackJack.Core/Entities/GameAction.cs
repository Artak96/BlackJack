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
    public class GameAction  :BaseEntity
    {
        [Key]
        public int ActionId { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        [ForeignKey("RoundId")]
        public int RoundId { get; set; }
        public ActionType Type { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Round> Rounds { get; set; }

    }
}
