using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class AddFavoriteCommandHandler : IRequestHandler<AddFavoriteCommand, Guid>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public AddFavoriteCommandHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(AddFavoriteCommand request, CancellationToken cancellationToken)
        {
            var dto = request.AddFavoriteDto;
            var favorite = _mapper.Map<Favorite>(dto);

            await _uow.Favorites.AddAsync(favorite);
            await _uow.SaveChangesAsync();

            return favorite.Id;
        }
    }
}
