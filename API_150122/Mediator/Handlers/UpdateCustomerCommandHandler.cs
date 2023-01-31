using API_150122.Mediator.Commands;
using API_150122.Models;
using API_150122.Repositories;

using MediatR;

namespace API_150122.Mediator.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        IGenericRepo<Customer> repo;

        public UpdateCustomerCommandHandler(IGenericRepo<Customer> repo)
        {
            this.repo = repo;
        }

        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            repo.Update(request.Customer);
            await repo.SaveChangesAsync();
            return request.Customer;
        }
    }
}
