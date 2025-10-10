using MediatR;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class DeletePropertyCommandHandler : IRequestHandler<DeletePropertyCommand>
    {
        private readonly IUnitOfWork _uow;

        public DeletePropertyCommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
        {
            await _uow.Properties.DeleteAsync(request.PropertyId);
            await _uow.SaveChangesAsync();
        }
    }
}
