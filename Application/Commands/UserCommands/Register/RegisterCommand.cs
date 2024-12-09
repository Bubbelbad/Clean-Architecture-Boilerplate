using Application.Dtos;
using Domain.Models;
using MediatR;

namespace Application.Commands.UserCommands.Register
{
    public class RegisterCommand(UserDto newUser) : IRequest<OperationResult<User>>
    {
        public UserDto NewUser { get; set; } = newUser;
    }
}