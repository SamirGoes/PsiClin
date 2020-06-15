using PsiClin.Domain.Core.Bus;
using PsiClin.Domain.Core.DomainNotifications;

namespace PsiClin.Domain.Core.Commands
{
    public class CommandHandler
    {
        // private readonly IUnitOfWork _uow;
        private readonly IMediatorHandler _bus;
        // private readonly DomainNotificationHandler _notifications;

        public CommandHandler(
            IMediatorHandler bus 
            // INotificationHandler<DomainNotification> notifications
            )
        {
            // _uow = uow;
            // _notifications = (DomainNotificationHandler)notifications;
            _bus = bus;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.Notifications)
            {
                _bus.RaiseEvent(new DomainNotification(error.Property, error.Message));
            }
        }

        public bool Commit()
        {
            // if (_notifications.HasNotifications()) return false;
            // if (_uow.Commit()) return true;

            _bus.RaiseEvent(new DomainNotification("Commit", "We had a problem during saving your data."));
            return false;
        }
    }
}