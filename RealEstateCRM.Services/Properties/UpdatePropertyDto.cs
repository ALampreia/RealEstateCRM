using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class UpdatePropertyDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public AddressDto Address { get; set; }
        public decimal Price { get; set; }
        public int Bathrooms { get; set; }
        public int Rooms { get; set; }
        public decimal PropertyArea { get; set; }
        public decimal TotalArea { get; set; }
        public byte? YearBuilt { get; set; }
        public string PropertyType { get; set; }
        public string PropertyStatus { get; set; }
        public Guid OwnerId { get; set; }
        public Guid ManagerId { get; set; }
        public Guid? RealtorId { get; set; }
        public Guid BrokerId { get; set; }
        public List<string>? Amenities { get; set; }
        public List<PropertyPhotoDto>? PropertyPhotos { get; set; }
    }
}
