using RealEstateCRM.Services.CommonDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Dtos
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserDetailsDto User { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string GoogleCalendarId { get; set; }
    }
}
