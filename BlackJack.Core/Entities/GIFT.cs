using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class GIFT : BaseEntity
    {
        [Key]
        public int GiftId { get; set; }
        [ForeignKey("PlayerId")]
        public int FromPlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public int ToPlayerId { get; set; }
        public int ItemType { get; set; }
        public int Quantity { get; set; }
        public DateTime Send_Time { get; set; }

    }
}
