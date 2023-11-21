using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IRepositories
{
    public interface IunitofWork
    {
        IGameRepository Providers { get; }

        void SaveChange();
        //void Dispose(bool disposing);
    }
}
