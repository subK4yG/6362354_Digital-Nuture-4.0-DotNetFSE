namespace DependencyInjectionExample
{
    public class CustomerService
    {
        private ICustomerRepo repo;
        public CustomerService(ICustomerRepo repo)
        {
            this.repo = repo;
        }
        public void ShowCustomer(string id)
        {
            string info = repo.GetCustomerById(id);
            System.Console.WriteLine(info);
        }
    }
}
