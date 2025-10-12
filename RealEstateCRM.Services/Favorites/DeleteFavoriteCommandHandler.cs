using MediatR;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class DeleteFavoriteCommandHandler : IRequestHandler<DeleteFavoriteCommand>
    {
        private readonly IUnitOfWork _uow;

        public DeleteFavoriteCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Handle(DeleteFavoriteCommand request, CancellationToken cancellationToken)
        {
            await _uow.Favorites.DeleteAsync(request.FavoriteId);
            await _uow.SaveChangesAsync();
        }
    }
}
