using API_150122.Models;

using MediatR;

namespace API_150122.Mediator.Queries
{
    public class GetCustomerByIDQuery : IRequest<Customer>
    {
        public int id { get; set; }

        public GetCustomerByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
