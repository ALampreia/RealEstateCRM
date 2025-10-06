using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public Task AddAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Address?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
