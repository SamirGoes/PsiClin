using System;
using Flunt.Notifications;
using MediatR;

namespace PsiClin.Domain.Core.Events
{
    public abstract class Message : Notifiable, IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}