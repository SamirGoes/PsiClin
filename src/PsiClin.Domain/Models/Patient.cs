using System;
using PsiClin.Domain.Core.Models;
using PsiClin.Domain.ValueObjects;

namespace PsiClin.Domain.Models
{
    public class Patient : Entity
    {
        public Patient(Name name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public Name Name { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}