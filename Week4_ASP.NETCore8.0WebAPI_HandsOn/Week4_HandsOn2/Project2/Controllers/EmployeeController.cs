using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string> { "John", "Jane", "Bob" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");
            return Ok(employees[id]);
        }

        [HttpPost]
        public ActionResult<IEnumerable<string>> AddEmployee([FromBody] string name)
        {
            employees.Add(name);
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id, [FromBody] string name)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");
            employees[id] = name;
            return Ok(employees);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");
            employees.RemoveAt(id);
            return Ok(employees);
        }
    }
}
