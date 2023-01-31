using API_150122.Models;

using MediatR;

namespace API_150122.Mediator.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public Customer cust { get; set; }

        public DeleteCustomerCommand(Customer cust)
        {
            this.cust = cust;
        }
    }
}
