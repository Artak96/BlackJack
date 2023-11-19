using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Mineral_Transaction
    {
        [Key]
        public int MineralTransactionId { get; set;}
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        [ForeignKey("GameId")]
        public int GameId { get; set; }
        public int Initial_Player_Order { get; set; }
        public string? Score { get; set; }

    }
}
