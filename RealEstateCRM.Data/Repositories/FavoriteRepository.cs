using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Data.Repositories
{
    public class FavoriteRepository : IFavoriteRepository
    {
        public Task AddAsync(Favorite favorite)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Favorite>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Favorite?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Favorite>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Favorite favorite)
        {
            throw new NotImplementedException();
        }
    }
}
