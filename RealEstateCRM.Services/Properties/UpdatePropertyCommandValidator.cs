using FluentValidation;
using RealEstateCRM.Services.CommonValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class UpdatePropertyCommandValidator : AbstractValidator<UpdatePropertyCommand>
    {
        public UpdatePropertyCommandValidator() 
        {
            RuleFor(x => x.PropertyDto.Id).NotEmpty();

            When(x => x.PropertyDto.Address != null, () =>
            {
                RuleFor(x => x.PropertyDto.Address).SetValidator(new AddressDtoValidator());
            });
        }

    }
}
