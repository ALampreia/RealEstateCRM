using RealEstateCRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Address : AuditableEntity<Guid>
    {
        public Guid Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }
        private Address() { }
        private Address(string street, string city, string state, string zipCode, string country) : this()
        {
            Id = Guid.NewGuid();
            Street = street;
            City = city;
            State = state;
            ZipCode = ZipCode;
            Country = country;
        }

        public static Address Create(string street, string city, string state, string zipCode, string country)
        {
            if(string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required", nameof(street));
            if(string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required", nameof(city));
            if(string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required", nameof(state));
            if(string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("ZipCode is required", nameof(zipCode));
            if(string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country is required", nameof(country));

            return new Address(street, city, state, zipCode, country);
        }

        public void Update(string street, string city, string state, string zipCode, string country)
        {
            if(string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required", nameof(street));
            if(string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required", nameof(city));
            if(string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required", nameof(state));
            if(string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("ZipCode is required", nameof(zipCode));
            if(string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country is required", nameof(country));

            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            Update(DateTime.UtcNow);
        }

        public void Delete()
        {
            base.Delete();
        }

    }
}
