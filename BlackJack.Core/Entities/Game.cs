using BlackJack.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public GameStatus Status { get; set; }
        public decimal Min_Bet { get; set; }
        public decimal Max_Bet { get; set; }
        public int Player_Count { get; set; }
    }
}
