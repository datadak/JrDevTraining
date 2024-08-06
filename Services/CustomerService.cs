using SampleTest.Models;

namespace SampleTest.Services
{
    public class CustomerService : ICustomerService
    {
        /// <summary>
        ///  SAMPLE FAKE DATABASE
        /// </summary>

        public CustomerService()
        {
            _customers = SampleData();
        }

        private List<CustomerModel> _customers { get; set; }

        public List<CustomerModel> Customers()
        { 
            return _customers;
        }

        public int Create(CustomerModel customer)
        {
            customer.ID = _customers.Count;
            _customers.Add(customer);
            return customer.ID;
        }

        public int Update(CustomerModel customer)
        {
            var find = _customers.SingleOrDefault(x => x.ID == customer.ID);
            if (find == null)
            {
                throw new Exception("Not found");
            }
            Helpers.CopyPropertiesTo<CustomerModel, CustomerModel>(customer, find);
            return customer.ID;
        }

        public int Delete(CustomerModel customer)
        {
            var find = _customers.SingleOrDefault(x => x.ID == customer.ID);
            if (find == null)
            {
                throw new Exception("Not found");
            }
            _customers.Remove(customer);
            return customer.ID;
        }

        private List<CustomerModel> SampleData()
        {
            return new List<CustomerModel>
            {
                new CustomerModel
                {
                    ID = 1,
                    Name = "John Smith",
                    Address = "123 Road Street",
                    City = "McQueeney",
                    State = "TX",
                    Country = "US",
                    Phone = "555-123-1234",
                    PostalCode = "12345",
                },
                new CustomerModel
                {
                    ID = 2,
                    Name = "Jane Doe",
                    Address = "123 Elm Street",
                    City = "McQueeney",
                    State = "TX",
                    Country = "US",
                    Phone = "555-123-1238",
                    PostalCode = "55123",
                },
                new CustomerModel
                {
                    ID = 3,
                    Name = "Clark Kent",
                    Address = "123 Krypto Road",
                    City = "Smallville",
                    State = "KS",
                    Country = "US",
                    Phone = "555-123-5555",
                    PostalCode = "88888",
                },
            };
        }

    }
}
