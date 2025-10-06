using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public Task AddAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
