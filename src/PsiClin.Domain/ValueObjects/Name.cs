using System;
using PsiClin.Domain.Core.Models;

namespace PsiClin.Domain.ValueObjects
{
    public struct Name : IEquatable<Name>
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public bool Equals(Name other)
            => other.FirstName == this.FirstName && other.LastName == this.LastName;
    }
}