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
        public Name Name { get; private set; }
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
        public void AddAddress(Address address)
        {
            if(address == null)
                throw new ArgumentNullException(nameof(address), "Address is required");

            Addresses.Add(address);
        }
        public void UpdateAddress(Guid addressId, string addressLineOne, string AddressLineTwo, string city, string state, string zipCode, string country)
        {
            Address address = Addresses.FirstOrDefault(a => a.Id == addressId);
                if(address == null)
                    throw new ArgumentException("Address not found", nameof(addressId));
                address.Update(addressLineOne, AddressLineTwo, city, state, zipCode, country);
        }
        public void DeleteAddress(Guid addressId)
        {
            Address address = Addresses.FirstOrDefault(a => a.Id == addressId);
            if (address == null)
                throw new ArgumentException("Address not found", nameof(addressId));
            Addresses.Remove(address);
        }
        public void UpdateName(Name newName)
        {
            if(newName == null)
                throw new ArgumentNullException(nameof(newName), "Name is required");
            if(string.IsNullOrWhiteSpace(newName.FirstName))
                throw new ArgumentException("First name is required", nameof(newName.FirstName));
            if(string.IsNullOrWhiteSpace(newName.LastName))
                throw new ArgumentException("Last name is required", nameof(newName.LastName));

            Name = newName;
            Update(DateTime.UtcNow);
        }
        public void UpdatePhoto(string photoUrl)
        {
            if(string.IsNullOrWhiteSpace(photoUrl))
                throw new ArgumentException("Photo URL is required", nameof(photoUrl));

            PhotoUrl = photoUrl;
            Update(DateTime.UtcNow);
        }
        public void DeletePhoto()
        {
            PhotoUrl = null;
        }
        public void UpdateRole(Role newRole, User actingUser)
        {
            if(actingUser == null)
                throw new ArgumentNullException(nameof(actingUser));

            if (actingUser.Role != Role.Broker &&
                actingUser.Role != Role.Admin &&
                actingUser.Role != Role.SuperAdmin)
                throw new InvalidOperationException("No authorization");

            Role = newRole;
            Update(DateTime.UtcNow);
        }

    }
}
