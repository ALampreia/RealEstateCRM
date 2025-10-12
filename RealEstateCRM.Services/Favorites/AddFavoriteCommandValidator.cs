using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class AddFavoriteCommandValidator : AbstractValidator<AddFavoriteCommand>
    {
        public AddFavoriteCommandValidator()
        {
            RuleFor(x => x.AddFavoriteDto.UserId).NotEmpty();
            RuleFor(x => x.AddFavoriteDto.PropertyId).NotEmpty();
        }
    }
}
