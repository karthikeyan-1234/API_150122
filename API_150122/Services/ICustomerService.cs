using API_150122.Models.DTOs;

namespace API_150122.Services
{
    public interface ICustomerService
    {
        Task<CustomerDTO> AddNewCustomer(CustomerDTO newCus);
        Task<CustomerDTO> GetCustomerByID(int id);
        Task<bool> DeleteCustomerByID(int id);
        Task<CustomerDTO> UpdateCustomer(CustomerDTO Cus);
    }
}
