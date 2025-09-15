using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Contact
    {
        public int Id { get; private set; }
        public ContactType Type { get; private set; }
        public string Value { get; private set; }

        private Contact() { }

        public Contact(ContactType type, string value)
        {
            Type = type;
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

    }
}
