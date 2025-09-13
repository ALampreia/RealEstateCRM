using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IAccountRepository Accounts { get; }
        IAddressRepository Addresses { get; }
        IEmployeeRepository Employees { get; }
        IFavoriteRepository Favorites { get; }
        ICommentRepository Comments { get; }
        IContactRepository Contacts { get; }

        IPropertyRepository Properties { get; }
        Task<int> SaveChangesAsync();
    }
}
