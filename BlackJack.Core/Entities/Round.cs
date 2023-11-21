using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }
        [ForeignKey("GameId")]
        public int GameId { get; set; }
        public int Result { get; set; }
        public decimal Min_Bet { get; set; }
        public decimal Max_Bet { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime EndDate { get; set; }
        public int PlayerCount { get; set; }
        public ICollection<Bet> Bets { get; set; }


    }
}
