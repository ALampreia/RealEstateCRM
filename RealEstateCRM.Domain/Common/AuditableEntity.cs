using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Common
{
    public class AuditableEntity<TId> : SoftDelete<TId>, IAuditableEntity<int>, ISoftDelete, IEntity<TId>
    {
        public DateTime CreatedAt => throw new NotImplementedException();

        public int CreatedBy => throw new NotImplementedException();

        public DateTime? UpdatedAt => throw new NotImplementedException();

        public int UpdatedBy => throw new NotImplementedException();

        public bool IsDeleted => throw new NotImplementedException();

        public TId Id => throw new NotImplementedException();

        public void Create(DateTime created)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update(DateTime updated)
        {
            throw new NotImplementedException();
        }
    }

}
