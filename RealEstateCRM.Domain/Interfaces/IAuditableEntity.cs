using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Interfaces
{
    public interface IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public TUser CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public TUser? UpdatedBy { get; set; }
    }
}
