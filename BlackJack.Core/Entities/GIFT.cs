using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class GIFT: BaseEntity
    {
        public int Id { get; set; }
        public int FromPlayerId { get; set; }
        public int ToPlayerId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public DateTime GiftTime { get; set; }
    }
}
