using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class RegisterPropertyCommandValidator : AbstractValidator<RegisterPropertyCommand>
    {
        public RegisterPropertyCommandValidator()
        {
            RuleFor(x => x.PropertyDto.AddressDto.).NotEmpty();
        }
    }
}
