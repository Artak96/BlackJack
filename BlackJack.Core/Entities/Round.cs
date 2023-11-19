using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Round
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int DealerHandValue { get; set; }
        public int PlayerHandValue { get; set; }
        public string Result { get; set; }
    }
}
