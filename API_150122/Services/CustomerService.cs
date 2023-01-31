using API_150122.Mediator.Commands;
using API_150122.Mediator.Queries;
using API_150122.Models;
using API_150122.Models.DTOs;
using API_150122.Repositories;

using AutoMapper;

using MediatR;

namespace API_150122.Services
{
    public class CustomerService : ICustomerService
    {
        IGenericRepo<Customer> repo;
        IMapper mapper;
        IMediator mediator;

        public CustomerService(IGenericRepo<Customer> repo,IMapper mapper,IMediator mediator)
        {
            this.repo = repo;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task<CustomerDTO> AddNewCustomer(CustomerDTO newCus)
        {
            var cmd = new AddCustomerCommand(mapper.Map<Customer>(newCus));
            var customer = await mediator.Send(cmd);
            return mapper.Map<CustomerDTO>(customer);
        }

        public async Task<CustomerDTO> UpdateCustomer(CustomerDTO Cus)
        {
            var cmd = new UpdateCustomerCommand(mapper.Map<Customer>(Cus));
            var customer = await mediator.Send(cmd);
            return mapper.Map<CustomerDTO>(customer);
        }

        public async Task<CustomerDTO> GetCustomerByID(int id)
        {
            var qry = new GetCustomerByIDQuery(id);
            var customer = await mediator.Send(qry);

            if (customer is not null)
                return mapper.Map<CustomerDTO>(customer);

            return null;
        }

        public async Task<bool> DeleteCustomerByID(int id)
        {
            var qry = new GetCustomerByIDQuery(id);
            var customer = await mediator.Send(qry);

            if(customer is not null)
            {
                var cmd = new DeleteCustomerCommand(customer);
                var result = await mediator.Send(cmd);
                return result;
            }

            return false;
        }
    }
}
