using System;
using PsiClin.Domain.Core.Models;
using PsiClin.Domain.Models.ValueObjects;

namespace PsiClin.Domain.Models
{
    public class Psychologist : Entity
    {
        public Psychologist(Guid id, Name name, string registerNumber)
        {
            Id = id;
            Name = name;
            RegisterNumber = registerNumber;
        }

        public Name Name { get; private set; }

        public string RegisterNumber { get; private set; }

        public void ScheduleAppointment(Patient patient)
        {

        }
    }
}