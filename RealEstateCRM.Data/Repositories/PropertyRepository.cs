using Microsoft.EntityFrameworkCore.Metadata;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        public Task AddAsync(Property property)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByBrokerIdAsync(Guid brokerId)
        {
            throw new NotImplementedException();
        }

        public Task<Property?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByLocationAsync(string location)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByManagerIdAsync(Guid managerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByOwnerIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByRealtorIdAsync(Guid realtorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetByTypeAsync(string type)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Property property)
        {
            throw new NotImplementedException();
        }
    }
}
