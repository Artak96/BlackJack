using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IServices
{
    public interface ILogingService
    {
        Task ErrorAsync(Exception exception, string caller);
        Task InfoAsync(string message, [CallerMemberName] string callerMethodName = default);
        Task DebugAsync(string message, [CallerMemberName] string callerMethodName = default);
    }
}
