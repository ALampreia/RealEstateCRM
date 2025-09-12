using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IPropertyRepository
    {
        Task<Property?> GetByIdAsync(Guid id);
        Task<IEnumerable<Property>> GetAllAsync();
        Task<IEnumerable<Property>> GetByOwnerIdAsync(Guid userId);
        Task<IEnumerable<Property>> GetByManagerIdAsync(Guid managerId);
        Task<IEnumerable<Property>> GetByRealtorIdAsync(Guid realtorId);
        Task<IEnumerable<Property>> GetByBrokerIdAsync(Guid brokerId);
        Task<IEnumerable<Property>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<IEnumerable<Property>> GetByTypeAsync(string type);
        Task<IEnumerable<Property>> GetByLocationAsync(string location);
        Task<IEnumerable<Property>> GetByStatusAsync(string status);
        Task AddAsync(Property property);
        Task UpdateAsync(Property property);
        Task DeleteAsync(Guid id);
    }
}
