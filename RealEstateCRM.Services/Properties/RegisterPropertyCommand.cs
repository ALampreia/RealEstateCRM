using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class RegisterPropertyCommand : IRequest<Guid>
    {
        public RegisterPropertyDto PropertyDto { get; set; }
        public RegisterPropertyCommand(RegisterPropertyDto propertyDto)
        {
            PropertyDto = propertyDto;
        }

    }
}
