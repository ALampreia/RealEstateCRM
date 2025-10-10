using FluentValidation;
using RealEstateCRM.Services.CommonValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(x => x.UserDto.Id).NotEmpty();

            When(x => x.UserDto.NameDto != null, () =>
            {
                RuleFor(x => x.UserDto.NameDto).SetValidator(new NameDtoValidator());
            });

            When(x => x.UserDto.AccountDto != null, () =>
            {
                RuleFor(x => x.UserDto.AccountDto).SetValidator(new AccountDtoValidator());
            });

            When(x => x.UserDto.Addresses != null, () =>
            {
                RuleForEach(x => x.UserDto.Addresses).SetValidator(new AddressDtoValidator());
            });

            When(x => x.UserDto.Contacts != null, () =>
            {
                RuleForEach(x => x.UserDto.Contacts).SetValidator(new ContactDtoValidator());
            });
        }
    }
}
