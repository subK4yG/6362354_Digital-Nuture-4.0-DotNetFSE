using System;
class Employee
{
    public int employeeId;
    public string name;
    public string position;
    public double salary;
    public void Show()
    {
        Console.WriteLine($"{employeeId} - {name} - {position} - Rs.{salary}");
    }
}
class Program
{
    static Employee[] emps = new Employee[100];
    static int count = 0;
    static void Add(Employee e)
    {
        if (count < emps.Length)
            emps[count++] = e;
    }
    static Employee Search(int id)
    {
        for (int i = 0; i < count; i++)
            if (emps[i].employeeId == id)
                return emps[i];
        return null;
    }
    static void Traverse()
    {
        Console.WriteLine("All Employees:");
        for (int i = 0; i < count; i++)
            emps[i].Show();
    }
    static void Delete(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (emps[i].employeeId == id)
            {
                for (int j = i; j < count - 1; j++)
                    emps[j] = emps[j + 1];
                emps[--count] = null;
                Console.WriteLine($"Employee {id} deleted.");
                return;
            }
        }
        Console.WriteLine("Employee not found.");
    }
    static void Main()
    {
        Add(new Employee { employeeId = 101, name = "Ram", position = "Manager", salary = 50000 });
        Add(new Employee { employeeId = 102, name = "Sita", position = "HR", salary = 40000 });
        Add(new Employee { employeeId = 103, name = "Lakshman", position = "Dev", salary = 35000 });
        Traverse();
        Console.WriteLine("\nSearching for Employee with ID 102:");
        var result = Search(102);
        if (result != null)
            result.Show();
        else
            Console.WriteLine("Not found");
        Console.WriteLine("\nDeleting Employee with ID 101:");
        Delete(101);
        Console.WriteLine("\nAfter Deletion:");
        Traverse();
    }
}
