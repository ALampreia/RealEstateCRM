using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class RegisterPropertyCommandHandler : IRequestHandler<RegisterPropertyCommand, Guid>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RegisterPropertyCommandHandler(IUnitOfWork uow, IMapper mapper )
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(RegisterPropertyCommand request, CancellationToken cancellationToken)
        {
            var dto = request.PropertyDto;
            var property = _mapper.Map<Property>(dto);

            await _uow.Properties.AddAsync(property);
            await _uow.SaveChangesAsync();

            return property.Id;
        }
    }
}
