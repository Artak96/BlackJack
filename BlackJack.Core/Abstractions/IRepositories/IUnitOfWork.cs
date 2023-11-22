using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IRepositories
{
    public interface IUnitOfWork
    {
        IGameRepository Providers { get; }
        IPlayerRepository Player { get; }

        void SaveChange();
        void Dispose(bool disposing);
    }
}
