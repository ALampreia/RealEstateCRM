using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class GetFavoritesByUserIdHandler : IRequestHandler<GetFavoritesByUserId, List<FavoriteDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetFavoritesByUserIdHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<List<FavoriteDto>> Handle(GetFavoritesByUserId request, CancellationToken cancellationToken)
        {
            var favorites = await _uow.Favorites.GetByUserIdAsync(request.UserId);
            return _mapper.Map<List<FavoriteDto>>(favorites);
        }
    }
}
