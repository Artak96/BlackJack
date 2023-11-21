using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Transfer : BaseEntity
    {
        [Key]
        public int TransferId { get; set; }
        [ForeignKey("PlayerId")]
        public int FromPlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public int ToPlayerId { get; set; }

        public decimal Amount { get; set; }
        public DateTime TransferTime { get; set; }
    }
}
