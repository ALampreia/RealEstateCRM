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

        public RegisterUserCommandHandler(IUnitOfWork uow, IPasswordHasher passwordHasher)
        {
            _uow = uow;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var (hash, salt) = _passwordHasher.HashPassword(request.Password);

            var name = new Name(request.FirstName, request.MiddleNames ?? string.Empty, request.LastName);
            var contacts = new List<Contact>
            {
                new Contact(ContactType.Email, request.Email)
            };

            var user = User.Create(
                Guid.NewGuid(),
                name,
                contacts,
                request.Email,
                hash,
                salt,
                request.TaxNumber,
                Role.Registered
            );

            await _uow.Users.AddAsync(user);
            await _uow.SaveChangesAsync();


            return user.Id;
        }
    }
}
