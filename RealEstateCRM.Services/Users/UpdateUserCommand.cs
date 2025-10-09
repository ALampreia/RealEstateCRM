using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class UpdateUserCommand : IRequest
    {
        public UpdateUserDto UserDto { get; set; }
        public UpdateUserCommand(UpdateUserDto userDto)
        {
            this.UserDto = userDto;
        }
    }
}
