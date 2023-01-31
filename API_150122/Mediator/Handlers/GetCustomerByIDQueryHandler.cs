using API_150122.Mediator.Queries;
using API_150122.Models;
using API_150122.Repositories;

using MediatR;

namespace API_150122.Mediator.Handlers
{
    public class GetCustomerByIDQueryHandler : IRequestHandler<GetCustomerByIDQuery, Customer>
    {
        IGenericRepo<Customer> repo;

        public GetCustomerByIDQueryHandler(IGenericRepo<Customer> repo)
        {
            this.repo = repo;
        }

        public Task<Customer> Handle(GetCustomerByIDQuery request, CancellationToken cancellationToken)
        {
            var customer = repo.FindAll(c => c.id == request.id).FirstOrDefault();
            return Task.FromResult(customer);
        }
    }
}
