using System.Threading.Tasks;
using PsiClin.Domain.Core.Commands;
using PsiClin.Domain.Core.Events;

namespace PsiClin.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
