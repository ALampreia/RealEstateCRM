using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Enums;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using RealEstateCRM.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUnitOfWork _uow;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IUnitOfWork uow, IPasswordHasher passwordHasher, IMapper mapper)
        {
            _uow = uow;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var dto = request.UserDto;
            var name = _mapper.Map<Name>(dto.Name);
            var contacts = _mapper.Map<List<Contact>>(dto.Contacts);
            var (hash, salt) = _passwordHasher.HashPassword(dto.Account.Password);
            
            var user = User.Create(
                Guid.NewGuid(),
                name,
                contacts,
                dto.Account.Email,
                hash,
                salt,
                dto.TaxNumber,
                Role.Registered
            );

            if(dto.Addresses != null)
            {
                var addresses = _mapper.Map<List<Address>>(dto.Addresses);
                foreach( var address in addresses) 
                    user.AddAddress(address);
            }

            if(!string.IsNullOrWhiteSpace(dto.PhotoUrl))
                user.UpdatePhoto(dto.PhotoUrl);

            await _uow.Users.AddAsync(user);
            await _uow.SaveChangesAsync();


            return user.Id;
        }
    }
}
