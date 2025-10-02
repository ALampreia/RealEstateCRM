using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.CommonDtos
{
    public class CommentDto
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public Guid PropertyId { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}
