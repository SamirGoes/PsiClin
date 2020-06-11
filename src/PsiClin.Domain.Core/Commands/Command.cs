
using System;
using MediatR;
using PsiClin.Domain.Core.Events;

namespace PsiClin.Domain.Core.Commands
{
    public abstract class Command : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}