using BlackJack.Core.Abstractions;
using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private BlackJackDbContext _context;

        public UnitOfWork(BlackJackDbContext context)
        {
            _context = context;
        }

        private GameRepository _game;
        public IGameRepository Providers => _game ?? (_game = new GameRepository(_context));

        private PlayerRepository _player;
        public IPlayerRepository Player => _player ?? (_player = new PlayerRepository(_context));

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
