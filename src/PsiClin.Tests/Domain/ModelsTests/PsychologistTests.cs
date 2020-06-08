using PsiClin.Domain.Models;
using PsiClin.Domain.ValueObjects;
using System;
using Xunit;

namespace PsiClin.Tests.Domain.ModelsTests
{
    public class PsychologistTests
    {
        [Fact]
        public void ShouldReturnOkWhenPatientScheduleAppointment()
        {
            var id = Guid.NewGuid();
            var name = new Name("Samir", "Goes");
            var registerNumber = "12345678";

            var psychologist = new Psychologist(id, name, registerNumber);
        }
    }
}