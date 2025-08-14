using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IAuditableEntity<TUserId>
    {
        public DateTime CreatedAt { get;}
        public TUserId CreatedBy { get;}
        public DateTime? UpdatedAt { get;}
        public TUserId? UpdatedBy { get;}

        void Create(DateTime created);
        void Update(DateTime updated);


    }
}
