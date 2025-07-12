using Microsoft.AspNetCore.Mvc;
using WebApiHandson.Models;

namespace WebApiHandson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Salary = 5000 },
            new Employee { Id = 2, Name = "Jane", Salary = 6000 },
            new Employee { Id = 3, Name = "Mark", Salary = 5500 }
        };

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmp = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmp == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmp.Name = updatedEmp.Name;
            existingEmp.Salary = updatedEmp.Salary;

            return Ok(existingEmp);
        }
    }
}
