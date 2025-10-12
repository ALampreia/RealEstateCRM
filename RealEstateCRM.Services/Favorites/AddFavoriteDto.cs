using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Favorites
{
   
    public class AddFavoriteDto
    {
        public Guid UserId { get; set; }
        public Guid PropertyId { get; set; }
    }
    
}
