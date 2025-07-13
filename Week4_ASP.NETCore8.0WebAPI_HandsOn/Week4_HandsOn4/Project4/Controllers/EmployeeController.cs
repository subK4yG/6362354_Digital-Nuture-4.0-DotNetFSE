using Microsoft.AspNetCore.Mvc;
using Project4.Models;

namespace Project4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                Department = new Department { Id = 1, Name = "HR" },
                Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
                DateOfBirth = new DateTime(1990, 1, 1)
            },
            new Employee
            {
                Id = 2,
                Name = "Alice",
                Salary = 60000,
                Permanent = false,
                Department = new Department { Id = 2, Name = "Finance" },
                Skills = new List<Skill> { new Skill { Id = 2, Name = "Excel" } },
                DateOfBirth = new DateTime(1992, 5, 12)
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(employees);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Invalid employee id");

            employee.Name = updatedEmp.Name;
            employee.Salary = updatedEmp.Salary;
            employee.Permanent = updatedEmp.Permanent;
            employee.Department = updatedEmp.Department;
            employee.Skills = updatedEmp.Skills;
            employee.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(employee);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<string> DeleteEmployee(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Invalid employee id");

            employees.Remove(employee);

            return Ok($"Employee with ID {id} deleted successfully.");
        }
    }
}
