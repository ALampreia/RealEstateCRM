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
        public string? PhotoUrl { get; private set; }
        public bool IsActive { get; private set; }
        private User()
        {
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
            Favorites = new List<Favorite>();
            Account = null!;
            IsActive = true;
        }

        public User(Guid id, Name name, string taxNumber, Role role) : this()
        {
            Id = id;
            Name = name;
            TaxNumber = taxNumber;
            Role = role;
        }

        public static User Create(Guid id, Name name, List<Contact> contacts, string email, string passwordHash, string passwordSalt, string taxNumber, Role role)
        {
           if(id == Guid.Empty)
                throw new ArgumentException("Id is required", nameof(id));
           if (name == null)
                throw new ArgumentNullException(nameof(name), "Name is required");
              if (contacts == null || contacts.Count == 0)
                throw new ArgumentException("At least one contact is required", nameof(contacts));
              if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required", nameof(email));
              if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password hash is required", nameof(passwordHash));
              if (string.IsNullOrWhiteSpace(passwordSalt))
                throw new ArgumentException("Password salt is required", nameof(passwordSalt));
              if(string.IsNullOrWhiteSpace(taxNumber))
                throw new ArgumentException("Tax number is required", nameof(taxNumber));

            User user = new User(id, name, taxNumber, role)
            {
                Contacts = contacts
            };

            user.Account = Account.Create(email, passwordHash, passwordSalt, id, user);

            bool hasMatchingEmail = contacts.Any(c => c.Type == ContactType.Email && c.Value.Equals(email, StringComparison.OrdinalIgnoreCase));
            if(!hasMatchingEmail)            
                throw new ArgumentException("The email must match one of the contact emails.", nameof(email));
            
            return user;
        }

        public void Update()
    }
}
