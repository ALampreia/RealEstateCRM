using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class UpdatePropertyCommand : IRequest
    {
        public UpdatePropertyDto PropertyDto { get; set; }
        public UpdatePropertyCommand(UpdatePropertyDto propertyDto)
        {
            PropertyDto = propertyDto;
        }
    }
}
