using Domain.Models;
using MediatR;

namespace Application.Queries.UserQueries.GetAllUsers
{
    public class GetAllUsersQuery() : IRequest<OperationResult<List<User>>>
    {

    }
}
