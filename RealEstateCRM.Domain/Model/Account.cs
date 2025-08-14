using RealEstateCRM.Domain.Common;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
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
        private Account()
        { 
            Email = string.Empty;
            PasswordHash = string.Empty;
            PasswordSalt = string.Empty;
        }
        private Account(string email, string passwordHash, string passwordSalt, Guid userId) : this() 
        {            
           Id = Guid.NewGuid();
           Email = email;
           PasswordHash = passwordHash;
           PasswordSalt = passwordSalt;
           UserId = userId;
        }
        public static Account Create(string email, string passwordHash, string passwordSalt, Guid userId)
        {
            return new Account(email, passwordHash, passwordSalt, userId);
        } 
    }
}
