using RealEstateCRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class PropertyImage : AuditableEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }
        public string ImageUrl { get; set; }
    }
}
