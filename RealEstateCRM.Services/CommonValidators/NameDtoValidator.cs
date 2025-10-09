using FluentValidation;
using RealEstateCRM.Services.CommonDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.CommonValidators
{
    public class NameDtoValidator : AbstractValidator<NameDto>
    {
        public NameDtoValidator() 
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}
