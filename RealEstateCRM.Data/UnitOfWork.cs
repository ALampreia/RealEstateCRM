using RealEstateCRM.Data.Context;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RealEstateCrmDbContext _context;

        public IAccountRepository Accounts { get; }
        public IAddressRepository Addresses { get; }
        public ICommentRepository Comments { get; }
        public IContactRepository Contacts { get; }
        public IEmployeeRepository Employees { get; }
        public IFavoriteRepository Favorites { get; }
        public IPropertyRepository Properties { get; }
        public IUserRepository Users { get; }

        public UnitOfWork(
            RealEstateCrmDbContext context,
            IAccountRepository accounts,
            IAddressRepository addresses,
            ICommentRepository comments,
            IContactRepository contacts,
            IEmployeeRepository employees,
            IFavoriteRepository favorites,
            IPropertyRepository properties,
            IUserRepository users)
        {
             _context = context;
            Accounts = accounts;
            Addresses = addresses;
            Comments = comments;
            Contacts = contacts;
            Employees = employees;
            Favorites = favorites;
            Properties = properties;
            Users = users;
        }
        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
