using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class GameAction
    {
        public int Id { get; set; }
        public int ParticipiantDealerId { get; set; }
        public int RoundId { get; set; }
        public string Type { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
