using System;

namespace PsiClin.Domain.Models
{
    public class Appointment
    {
        public Appointment(Guid id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public bool Approved { get; private set; }

        public void Approve()
        {
            Approved = true;
        }

        internal void Reprove()
        {
            Approved = false;
        }
    }
}