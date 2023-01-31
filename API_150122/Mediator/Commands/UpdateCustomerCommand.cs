using API_150122.Models;

using MediatR;

namespace API_150122.Mediator.Commands
{
    public class UpdateCustomerCommand:IRequest<Customer>
    {
        public Customer Customer { get; set; }

        public UpdateCustomerCommand(Customer UpdateCustomer)
        {
            this.Customer = UpdateCustomer;
        }
    }
}
