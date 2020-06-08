using System;

namespace PsiClin.Domain.Core.Models
{
    public abstract class ValueObject
    {
       public override bool Equals(object obj)
        {
            var valueObject = obj as ValueObject;
            return !ReferenceEquals(valueObject, null);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + GetHashCode();
        }

        public static bool operator ==(ValueObject a, ValueObject b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject a, ValueObject b)
        {
            return !(a == b);
        }
    }
}