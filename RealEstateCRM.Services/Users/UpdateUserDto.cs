using RealEstateCRM.Services.CommonDtos;
using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class UpdateUserDto
    {
        public Guid Id { get; set; }
        public NameDto? NameDto { get; set; }
        public AccountDto? AccountDto { get; set; }
        public string? TaxNumber { get; set; }
        public List<ContactDto>? Contacts { get; set; }
        public List<AddressDto>? Addresses { get; set; }
        public string? PhotoUrl { get; set; }


    }
}
