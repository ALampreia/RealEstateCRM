using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Name
    {
        public string FirstName { get; private set; }
        public string MiddleNames { get; private set; }
        public string LastName { get; private set; }

        public string FullName => $"{FirstName} {string.Join(" ", MiddleNames)} {LastName}";

        private Name()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            MiddleNames = string.Empty;
        }

        public Name(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name(string firstName, string middleNames, string lastName) : this(firstName, lastName)
        {
            MiddleNames = middleNames;
        }

        public Name(string fullName) : this(
              fullName.Split(" ")[0],
              fullName.Split(" ")[fullName.Split(" ").Length - 1])
        {
        }
    }
}
