using MediatR;
using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class RegisterUserCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string? MiddleNames { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TaxNumber { get; set; }
    }
}
