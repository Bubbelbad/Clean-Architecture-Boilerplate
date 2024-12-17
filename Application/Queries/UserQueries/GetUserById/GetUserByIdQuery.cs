using Domain.Models;
using MediatR;

namespace Application.Queries.UserQueries.GetUserById
{
    public class GetUserByIdQuery(Guid id) : IRequest<OperationResult<User>>
    {
        public Guid Id { get; set; }
    }
}
