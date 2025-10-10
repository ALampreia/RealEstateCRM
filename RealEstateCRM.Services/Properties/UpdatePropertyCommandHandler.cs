using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class UpdatePropertyCommandHandler : IRequestHandler<UpdatePropertyCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UpdatePropertyCommandHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePropertyCommand request, CancellationToken cancellationToken)
        {
            var dto = request.PropertyDto;
            var property = await _uow.Properties.GetByIdAsync(dto.Id);

            if (property == null)
                throw new Exception("Property not found");

            _mapper.Map(dto, property);

            await _uow.Properties.UpdateAsync(property);
            await _uow.SaveChangesAsync();
        }
    }
}
