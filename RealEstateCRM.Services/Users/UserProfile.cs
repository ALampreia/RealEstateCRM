using AutoMapper;
using RealEstateCRM.Domain.Model;
using RealEstateCRM.Services.CommonDtos;
using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<ContactDto, Contact>();
            CreateMap<AddressDto, Address>();
            CreateMap<AccountDto,  Account>();
            CreateMap<NameDto, Name>();
        }
    }
}
