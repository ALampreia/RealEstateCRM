using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IAddressRepository
    {
        Task<Address?> GetByIdAsync(Guid id);
        Task<IEnumerable<Address>> GetAllAsync();
        Task<IEnumerable<Address>> GetByUserIdAsync(Guid userId);
        Task AddAsync(Address address);
        Task UpdateAsync(Address address);
        Task DeleteAsync(Guid id);

    }
}
