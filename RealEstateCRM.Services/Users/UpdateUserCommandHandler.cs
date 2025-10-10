using AutoMapper;
using MediatR;
using RealEstateCRM.Domain.Interfaces;
using RealEstateCRM.Domain.Model;
using RealEstateCRM.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class UpdateUserCommandHandler : IRequest<UpdateUserCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUnitOfWork uow, IPasswordHasher passwordHasher, IMapper mapper)
        {
            _uow = uow;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var dto = request.UserDto;
            var user = await _uow.Users.GetByIdAsync(dto.Id);

            if (user == null)
                throw new Exception("User not found");

            if (dto.NameDto != null)
                user.UpdateName(_mapper.Map<Name>(dto.NameDto));

            if (dto.PhotoUrl != null)
                user.UpdatePhoto(dto.PhotoUrl);

            if (dto.AccountDto?.Password != null)
            {
                var (hash, salt) = _passwordHasher.HashPassword(dto.AccountDto.Password);
                user.Account.UpdatePassword(hash, salt);
            }

            if (dto.Contacts != null)
            {
                user.Contacts.Clear();
                user.Contacts.AddRange(_mapper.Map<List<Contact>>(dto.Contacts));
            }

            if (dto.Addresses != null)
            {
                user.Addresses.Clear();
                user.Addresses.AddRange(_mapper.Map<List<Address>>(dto.Addresses));
            }

            await _uow.Users.UpdateAsync(user);
            await _uow.SaveChangesAsync();
        }
    }
}
