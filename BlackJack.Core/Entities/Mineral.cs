using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Mineral
    {
        [Key]
        public int MineralId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }

    }
}
