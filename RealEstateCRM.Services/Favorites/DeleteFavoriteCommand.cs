using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
    public  class DeleteFavoriteCommand : IRequest
    {
        
        public Guid FavoriteId { get; set; }
        public DeleteFavoriteCommand(Guid favoriteId)
        { 
            FavoriteId = favoriteId;
        }
       
    }
}
