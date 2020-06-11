using PsiClin.Domain.Models;
using PsiClin.Domain.ValueObjects;
using System;
using Xunit;

namespace PsiClin.Tests.Domain.ModelsTests
{
    public class PsychologistTests
    {
        [Fact]
        public void ShouldReturnOkWhenPatientScheduleAppointmentInValidDate()
        {
            var id = Guid.NewGuid();
            var psychologistName = new Name("Bianca", "Abreu");
            var registerNumber = "12345678";

            var patientName = new Name("Samir", "Góes");

            var patient = new Patient(patientName, new DateTime(1992, 06, 10));
            var dateOfAppointment = new DateTime(2020, 06, 20);
            var psychologist = new Psychologist(id, psychologistName, registerNumber);

            var appointment = psychologist.ScheduleAppointment(patient, dateOfAppointment);

            Assert.True(appointment.Approved);
        }
    }
}