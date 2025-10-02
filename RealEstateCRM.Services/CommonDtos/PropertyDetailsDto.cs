using RealEstateCRM.Domain.Enums;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.CommonDtos
{
    public class PropertyDetailsDto
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Address Address { get; private set; }
        public decimal Price { get; private set; }
        public int Bathrooms { get; private set; }
        public int Rooms { get; private set; }
        public decimal PropertyArea { get; private set; }
        public decimal TotalArea { get; private set; }
        public byte? YearBuilt { get; private set; }
        public PropertyType PropertyType { get; private set; }
        public PropertyStatus PropertyStatus { get; private set; }
        public List<PropertyImage> PropertyImages { get; private set; }
        public List<Comment> Comments { get; private set; }
        public Guid OwnerId { get; private set; }
        public User Owner { get; private set; }
        public Guid ManagerId { get; private set; }
        public User Manager { get; private set; }
        public Guid? RealtorId { get; private set; }
        public User? Realtor { get; private set; }
        public Guid BrokerId { get; private set; }
        public User Broker { get; private set; }
        public List<string> Amenities { get; private set; }
    }
}
