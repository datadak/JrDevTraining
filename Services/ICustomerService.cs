using SampleTest.Models;

namespace SampleTest.Services
{
    public interface ICustomerService
    {
        int Create(CustomerModel customer);
        List<CustomerModel> Customers();
        int Delete(CustomerModel customer);
        int Update(CustomerModel customer);
    }
}