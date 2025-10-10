using AutoMapper;
using RealEstateCRM.Domain.Model;
using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile() 
        {
            CreateMap<RegisterPropertyDto, Property>();
            CreateMap<AddressDto, Address>();
            CreateMap<PropertyPhotoDto, PropertyImage>();
            CreateMap<UpdatePropertyDto, Property>();
        }

    }
}
