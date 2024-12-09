using Domain.Models;
using MediatR;

namespace Application.Commands.UserCommands.Register
{
    public class RegisterCommandHandler() : IRequestHandler<RegisterCommand, OperationResult<User>>
    {
        public Task<OperationResult<User>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
