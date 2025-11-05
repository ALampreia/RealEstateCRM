using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class GetFavoritesByUserIdValidator : AbstractValidator<GetFavoritesByUserId>
    {
        public GetFavoritesByUserIdValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required");
        }
    }
}
