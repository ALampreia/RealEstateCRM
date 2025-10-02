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
        public string? FirstName { get; set; }
        public string? MiddleNames { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? TaxNumber { get; set; }
        public List<ContactDto>? Contacts { get; set; }
        public List<AddressDto>? Addresses { get; set; }
        public List<FavoriteDto>? Favorites { get; set; }
        public string? PhotoUrl { get; set; }


    }
}
