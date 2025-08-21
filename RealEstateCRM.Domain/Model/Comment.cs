using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Comment
    {
        public int Id { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public string Content { get; private set; }
        public Guid PropertyId { get; private set; }
        public Property Property { get; private set; }

    }
}
