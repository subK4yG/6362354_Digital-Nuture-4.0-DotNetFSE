namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepo repo = new CustomerRepo();
            CustomerService service = new CustomerService(repo);
            service.ShowCustomer("Zt1947");
        }
    }
}
