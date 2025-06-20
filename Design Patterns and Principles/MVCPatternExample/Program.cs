using System;
namespace MVCPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { Name = "Anand", Id = "111", Grade = "A" };
            StudentView v = new StudentView();
            StudentController c = new StudentController(s, v);
            c.UpdateView();
            c.SetName("Viswanath");
            c.SetGrade("B+");
            c.UpdateView();
        }
    }
}
