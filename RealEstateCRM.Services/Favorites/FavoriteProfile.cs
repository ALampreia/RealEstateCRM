using AutoMapper;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class FavoriteProfile : Profile
    {
        public FavoriteProfile() 
        {
            CreateMap<Favorite, FavoriteDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.UserId))
                .ForMember(d => d.PropertyId, o => o.MapFrom(s => s.PropertyId));
        }

    }
}
