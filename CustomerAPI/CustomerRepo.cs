
namespace CustomerAPI
{
    public class CustomerRepo : ICustomerRepo
    {
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Yash", LastName = "Patel" },
            new Customer { Id = 2, FirstName = "ysh", LastName = "Ptl" },
            
        };
        }
    }
}
