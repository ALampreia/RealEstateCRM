using RealEstateCRM.Domain.Common;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Account : AuditableEntity<Guid>
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string PasswordSalt { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        private Account(){}
        private Account(string email, string passwordHash, string passwordSalt, Guid userId, User user) : this() 
        {            
           Id = Guid.NewGuid();
           Email = email;
           PasswordHash = passwordHash;
           PasswordSalt = passwordSalt;
           UserId = userId;
           User = user;
        }
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static Account Create(string email, string passwordHash, string passwordSalt, Guid userId, User user)
        {
            if(string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required", nameof(email));
            if(!IsValidEmail(email))
                throw new ArgumentException("Email is not valid", nameof(email));
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password hash is required", nameof(passwordHash));
            if(string.IsNullOrWhiteSpace(passwordSalt))
                throw new ArgumentException("Password salt is required", nameof(passwordSalt));
            if(userId == Guid.Empty)
                throw new ArgumentException("User not found", nameof(userId));
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User is required");

            return new Account(email, passwordHash, passwordSalt, userId, user);
        } 

        public void Update(string email, string passwordHash, string passwordSalt)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required", nameof(email));
            if (!IsValidEmail(email))
                throw new ArgumentException("Email is not valid", nameof(email));
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password hash is required", nameof(passwordHash));
            if (string.IsNullOrWhiteSpace(passwordSalt))
                throw new ArgumentException("Password salt is required", nameof(passwordSalt));

            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Update(DateTime.UtcNow);

        }

        public void Delete()
        {
            base.Delete();
        }
    }
}
