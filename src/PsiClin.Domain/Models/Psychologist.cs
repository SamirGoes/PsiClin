using System;
using PsiClin.Domain.Core.Models;
using PsiClin.Domain.ValueObjects;

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

        public Appointment ScheduleAppointment(Patient patient, DateTime dateOfAppointment)
        {
            var appointment = new Appointment(Guid.NewGuid(), dateOfAppointment);
            
            if(dateOfAppointment > DateTime.Now)
                appointment.Reprove();
            
            return appointment;
        }
    }
}