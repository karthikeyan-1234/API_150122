using API_150122.Models;
using API_150122.Models.DTOs;

using MediatR;

namespace API_150122.Mediator.Commands
{
    public class AddCustomerCommand : IRequest<Customer>
    {
        public Customer newCustomer { get; set; }

        public AddCustomerCommand(Customer newCustomer)
        {
            this.newCustomer = newCustomer;
        }
    }
}
