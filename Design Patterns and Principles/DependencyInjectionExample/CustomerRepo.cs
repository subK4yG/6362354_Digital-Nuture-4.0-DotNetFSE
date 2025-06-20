namespace DependencyInjectionExample
{
    public class CustomerRepo : ICustomerRepo
    {
        public string GetCustomerById(string id)
        {
            return $"Customer: {id} - Viswanathan Anand";
        }
    }
}
