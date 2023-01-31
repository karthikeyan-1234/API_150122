using API_150122.Mediator.Commands;
using API_150122.Models;
using API_150122.Repositories;

using MediatR;

namespace API_150122.Mediator.Handlers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {
        IGenericRepo<Customer> repo;

        public DeleteCustomerCommandHandler(IGenericRepo<Customer> repo)
        {
            this.repo = repo;
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            repo.Delete(request.cust);
            await repo.SaveChangesAsync();
            return true;
        }
    }
}
