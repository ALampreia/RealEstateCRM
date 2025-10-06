using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator() 
        {
            RuleFor(x => x.UserDto.FirstName).NotEmpty();
            RuleFor(x => x.UserDto.LastName).NotEmpty();
            RuleFor(x => x.UserDto.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.UserDto.Password).NotEmpty().MinimumLength(4);
            RuleFor(x => x.UserDto.TaxNumber).NotEmpty();
        }
    }
}
