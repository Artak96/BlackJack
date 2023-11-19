using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Entities
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? User_Name { get; set; }
        public string? Nick_Name { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public decimal Balance { get; set; }
        public DateTime Last_Login { get; set; }


    }
}
