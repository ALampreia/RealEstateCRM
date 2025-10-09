using FluentValidation;
using RealEstateCRM.Services.CommonDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.CommonValidators
{
    public class AccountDtoValidator : AbstractValidator<AccountDto>
    {
        public AccountDtoValidator() 
        {
            RuleFor(x => x.Email).NotEmpty()
                .EmailAddress();
            RuleFor(x => x.Password).NotEmpty()
                .MinimumLength(6)
                .MaximumLength(20);

        }
    }
}
