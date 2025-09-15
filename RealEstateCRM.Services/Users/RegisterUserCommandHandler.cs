using MediatR;
using RealEstateCRM.Domain.Interfaces;
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

        }


        return Users.Id;
    }
}
