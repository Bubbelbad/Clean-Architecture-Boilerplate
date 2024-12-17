using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using MediatR;

namespace Application.Commands.UserCommands.Register
{
    public class RegisterCommandHandler(IGenericRepository<User> repository, IMapper mapper) : IRequestHandler<RegisterCommand, OperationResult<User>>
    {
        private readonly IGenericRepository<User> _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<OperationResult<User>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            try
            {
                User user = new User
                {
                    UserName = request.NewUser.UserName,
                    Email = request.NewUser.Password,
                };

                var createdUser = _repository.AddAsync(user);
                var mappedUser = _mapper.Map<User>(createdUser);

                return OperationResult<User>.Success(mappedUser);
            }
            catch
            {
                throw new ArgumentException("Invalid user data");
            }

        }
    }
}
