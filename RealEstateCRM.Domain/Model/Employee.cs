using RealEstateCRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Employee : AuditableEntity<Guid>
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }  
        public User User { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime HireDate { get; private set; }
        public DateTime? TerminationDate { get; private set; }
        public string GoogleCalendarId { get; private set; }

    }
}
