using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<Favorite?> GetByIdAsync(Guid id);
        Task<IEnumerable<Favorite>> GetAllAsync();
        Task<IEnumerable<Favorite>> GetByUserIdAsync(Guid userId);
        Task AddAsync(Favorite favorite);
        Task UpdateAsync(Favorite favorite);
        Task DeleteAsync(Guid id);
    }
}
