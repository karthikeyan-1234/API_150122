using API_150122.Mediator.Commands;
using API_150122.Models;
using API_150122.Models.DTOs;
using API_150122.Repositories;

using AutoMapper;

using MediatR;

namespace API_150122.Mediator.Handlers
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand,Customer>
    {
        IGenericRepo<Customer> genericRepo;

        public AddCustomerCommandHandler(IGenericRepo<Customer> genericRepo)
        {
            this.genericRepo = genericRepo;
        }

        public async Task<Customer> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await genericRepo.AddAsync(request.newCustomer);
            await genericRepo.SaveChangesAsync();
            return customer;
        }
    }
}
