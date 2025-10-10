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

            RuleFor(x => x.UserDto.Contacts).NotEmpty().NotNull();
            RuleFor(x => x.UserDto.TaxNumber).NotEmpty();

            When(x => x.UserDto.Addresses != null, () =>
            {
                RuleForEach(x => x.UserDto.Addresses).SetValidator(new AddressDtoValidator());
            });
        }
    }
}
