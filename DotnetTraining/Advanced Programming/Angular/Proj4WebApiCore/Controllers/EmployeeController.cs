using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proj4WebApiCore.Models;

namespace Proj4WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeData component;
        public EmployeeController(IEmployeeData component)
        {
             this.component = component;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees() => await component.GetAllEmployees();

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id) => await component.GetEmployee(id);

        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee(Employee emp)
        {
            await component.AddEmployee(emp);
            return CreatedAtAction(nameof(GetEmployee),new { id = emp.EmpId}, emp);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateRecord(int id, Employee emp)
        {
            return await component.UpdateEmployee(id, emp);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteRecord(int id)
        {
            await component.DeleteEmployee(id);
            return await new Task<string>(() => "Employee is deleted successfully");
        }
    }
}
