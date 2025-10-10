using FluentValidation;
using RealEstateCRM.Services.CommonValidators;
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
            RuleFor(x => x.PropertyDto.Title).NotEmpty();
            RuleFor(x => x.PropertyDto.Description).NotEmpty();
            RuleFor(x => x.PropertyDto.Address)
                .NotNull()
                .SetValidator(new AddressDtoValidator());
            RuleFor(x => x.PropertyDto.Price).GreaterThan(0);
            RuleFor(x => x.PropertyDto.PropertyType).NotEmpty();
            RuleFor(x => x.PropertyDto.PropertyStatus).NotEmpty();
            RuleFor(x => x.PropertyDto.OwnerId).NotEmpty();
            RuleFor(x => x.PropertyDto.ManagerId).NotEmpty();
            RuleFor(x => x.PropertyDto.BrokerId).NotEmpty();
        }
    }
}
