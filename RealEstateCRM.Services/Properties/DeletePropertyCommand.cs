using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Properties
{
    public class DeletePropertyCommand :  IRequest
    {
        public Guid PropertyId { get; set; }
        public DeletePropertyCommand(Guid propertyId) 
        { 
            PropertyId = propertyId;
        }
    }
}
