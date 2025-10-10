using FluentValidation;
using RealEstateCRM.Domain.Enums;
using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.CommonValidators
{
    public class ContactDtoValidator : AbstractValidator<ContactDto>
    {
        public ContactDtoValidator() 
        {
           RuleFor(x => x.Value).NotEmpty();

            RuleFor(x => x)
                 .Must(c =>
                 {
                     if (c.Type == ContactType.Mobile || c.Type == ContactType.Landline )
                         return !string.IsNullOrWhiteSpace(c.Value) && c.Value.All(char.IsDigit);
                     return true;
                 })
                 .WithMessage("Mobile and Landline contacts must contain only digits");

            When(x => x.Type == ContactType.Email, () =>
            {
                RuleFor(x => x.Value)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email contact must be a valid email address");
            });
        }
    }
}
