using API_150122.Models;
using API_150122.Models.DTOs;

using AutoMapper;

namespace API_150122.Mapping
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<CustomerDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
