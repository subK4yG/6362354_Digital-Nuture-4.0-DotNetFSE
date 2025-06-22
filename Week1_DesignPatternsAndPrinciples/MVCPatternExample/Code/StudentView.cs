using System;
namespace MVCPatternExample
{
    public class StudentView
    {
        public void DisplayStudentDetails(string name, string id, string grade)
        {
            Console.WriteLine($"Name: {name}, ID: {id}, Grade: {grade}");
        }
    }
}