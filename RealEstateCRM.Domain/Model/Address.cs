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
        public string AddressLineOne { get; private set; }
        public string? AddressLineTwo { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }
        private Address() { }
        private Address(string addressLineOne, string? addressLineTwo, string city, string state, string zipCode, string country) : this()
        {
            Id = Guid.NewGuid();
            AddressLineOne = addressLineOne;
            AddressLineTwo = addressLineTwo;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }

        public static Address Create(string addressLineOne, string? addressLineTwo, string city, string state, string zipCode, string country)
        {
            if(string.IsNullOrWhiteSpace(addressLineOne))
                throw new ArgumentException("Street is required", nameof(addressLineOne));
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required", nameof(city));
            if(string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required", nameof(state));
            if(string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("ZipCode is required", nameof(zipCode));
            if(string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country is required", nameof(country));

            return new Address(addressLineOne, addressLineTwo, city, state, zipCode, country);
        }

        public void Update(string addressLineOne, string? addressLineTwo, string city, string state, string zipCode, string country)
        {
            if(string.IsNullOrWhiteSpace(addressLineOne))
                throw new ArgumentException("Street is required", nameof(addressLineOne));
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required", nameof(city));
            if(string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required", nameof(state));
            if(string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("ZipCode is required", nameof(zipCode));
            if(string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country is required", nameof(country));

            AddressLineOne = addressLineOne;
            AddressLineTwo = addressLineTwo;
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
