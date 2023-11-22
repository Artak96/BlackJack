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
    public class Game : BaseEntity
    {
        [Key]
        public int GameId { get; set; }
        [ForeignKey("DealerId")]
        public int DealerId { get; set; }
        public GameStatus Status { get; set; }
        public decimal Min_Bet { get; set; }
        public decimal Max_Bet { get; set; }
        public int Player_Count { get; set; }

        public ICollection<Bet> Bets { get; set; }
        public ICollection<Dealer> Dealers { get; set; }
    }
}
