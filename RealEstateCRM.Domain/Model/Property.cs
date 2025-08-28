using RealEstateCRM.Domain.Common;
using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Property : AuditableEntity<Guid>
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

        private Property()
        {
            PropertyImages = new List<PropertyImage>();
            Comments = new List<Comment>();
            Amenities = new List<string>();
        }

        public Property(
            Guid id,
            string title,
            string description,
            Address address,
            decimal price,
            int bathrooms,
            int rooms,
            decimal propertyArea,
            decimal totalArea,
            byte? yearBuilt,
            PropertyType propertyType,
            PropertyStatus propertystatus,
            Guid ownerId,
            User owner,
            Guid managerId,
            User manager,
            Guid? realtorId,
            User? realtor,
            Guid brokerId,
            User broker,
            List<string> amenities
        ) : this()
        {
            Id = id;
            Title = title;
            Description = description;
            Address = address;
            Price = price;
            Bathrooms = bathrooms;
            Rooms = rooms;
            PropertyArea = propertyArea;
            TotalArea = totalArea;
            YearBuilt = yearBuilt;
            PropertyType = propertyType;
            PropertyStatus = propertystatus;
            OwnerId = ownerId;
            Owner = owner;
            ManagerId = managerId;
            Manager = manager;
            RealtorId = realtorId;
            Realtor = realtor;
            BrokerId = brokerId;
            Broker = broker;
            Amenities = amenities ?? new List<string>();
        }

        public void ChangeRealtorAndManager(User broker, User newRealtor, User newManager)
        {
            if(broker == null) throw new ArgumentNullException("Broker not found", nameof(broker));
            if (newRealtor == null) throw new ArgumentNullException("Realtor not found", nameof(newRealtor));
            if (newManager == null) throw new ArgumentNullException("Manager not found", nameof(newManager));

            if (broker.Id != BrokerId)
                throw new InvalidOperationException("Only the Broker can change the realtor and manager");

            ManagerId = newManager.Id;
            Manager = newManager;
            RealtorId = newRealtor.Id;
            Realtor = newRealtor;
        }

    }
}
