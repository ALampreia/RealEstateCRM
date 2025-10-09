using FluentValidation;
using RealEstateCRM.Services.CommonValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator() 
        {
            RuleFor(x => x.UserDto.Name)
                .NotNull()
                .SetValidator(new NameDtoValidator());
            RuleFor(x => x.UserDto.Account)
                .NotNull()
                .SetValidator(new AccountDtoValidator());
            RuleFor(x => x.UserDto.Contacts).NotEmpty();
            RuleFor(x => x.UserDto.TaxNumber).NotEmpty();

        }
    }
}
