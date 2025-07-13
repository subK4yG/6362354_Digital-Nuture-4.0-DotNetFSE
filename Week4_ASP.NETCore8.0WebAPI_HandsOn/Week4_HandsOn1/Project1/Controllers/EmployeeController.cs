using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string> { "John", "Jane", "Bob" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetEmployees()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult AddEmployee([FromBody] string name)
        {
            employees.Add(name);
            return Ok(employees);
        }
    }
}
