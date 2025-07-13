using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Project3.Models;
using Project3.Filters;
using System.Collections.Generic;
using System;

namespace Project3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))] 
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            };
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public ActionResult<List<Employee>> GetStandard()
        { 
            throw new Exception("Simulated crash for testing");
            //return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee emp)
        {
            return Ok(emp);
        }
    }
}
