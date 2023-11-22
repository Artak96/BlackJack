using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.Core.Entities;
using BlackJack.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DAL.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(BlackJackDbContext context) : base(context)
        {
        }
    }
}
