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
            CreateMap<RegisterPropertyDto, Property>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.PropertyImages, opt => opt.MapFrom(src => src.PropertyPhotos))
                .ForMember(dest => dest.Amenities, opt => opt.MapFrom(src => src.Amenities ?? new List<string>()));

            CreateMap<AddressDto, Address>();
            CreateMap<PropertyPhotoDto, PropertyImage>();
        }

    }
}
