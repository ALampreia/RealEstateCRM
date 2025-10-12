using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public class AddFavoriteCommand : IRequest<Guid>
    {
        public AddFavoriteDto AddFavoriteDto { get; set; }

        public AddFavoriteCommand(AddFavoriteDto addFavoriteDto) 
        {
            AddFavoriteDto = addFavoriteDto;
        }
    }
}
