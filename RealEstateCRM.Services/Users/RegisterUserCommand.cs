using MediatR;
using RealEstateCRM.Domain.Enums;
using RealEstateCRM.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Services.Users
{
    public class RegisterUserCommand : IRequest<Guid>
    {
        public RegisterUserDto UserDto {  get; set; }
        public RegisterUserCommand(RegisterUserDto userDto)
        {
            UserDto = userDto;
        }
}
