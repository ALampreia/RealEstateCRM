using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Dtos
{
    public class ContactDto
    {
        public ContactType Type { get; set; }
        public string Value { get; set; }
    }
}
