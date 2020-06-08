using System;
using PsiClin.Domain.Core.Models;
using PsiClin.Domain.ValueObjects;

namespace PsiClin.Domain.Models
{
    public class Patient : Entity
    {
        public Name Name { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}