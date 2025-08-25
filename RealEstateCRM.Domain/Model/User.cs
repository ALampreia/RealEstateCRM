using RealEstateCRM.Domain.Common;
using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class User : AuditableEntity<Guid>
    {
        public Guid Id { get; private set; }
        public Name Name { get; }
        public List<Address> Addresses { get; private set; }
        public List<Contact> Contacts { get; private set; }
        public Account Account { get; private set; }
        public List<Favorite> Favorites { get; private set; }
        public string TaxNumber { get; private set; }
        public Role Role { get; private set; }
        public string PhotoUrl { get; private set; }
        public bool IsActive { get; private set; }
        private User()
        {
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
            Favorites = new List<Favorite>();
            Account = null!;
            IsActive = true;
        }

        public User(Guid id, Name name, string taxNumber, Role role, string photoUrl) : this()
        {
            Id = id;
            Name = name;
            TaxNumber = taxNumber;
            Role = role;
        }
    }
}
