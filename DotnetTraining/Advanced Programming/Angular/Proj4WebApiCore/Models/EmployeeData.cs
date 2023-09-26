using Microsoft.EntityFrameworkCore;

namespace Proj4WebApiCore.Models
{
    public interface IEmployeeData
    {
        Task<List<Employee>> GetAllEmployees();

        Task<Employee> GetEmployee(int id);
        Task DeleteEmployee(int id);
        Task<Employee> UpdateEmployee(int id, Employee updateRec);
        Task<Employee> AddEmployee(Employee employee);
    }
    
    public class EmployeeData  : IEmployeeData
    {
        private readonly EmpDbContext dbContext;
        public EmployeeData(EmpDbContext context)
        {
            dbContext = context;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.Find(id);
            if (emp != null)
            {
                dbContext.Employees.Remove(emp);
            }
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await dbContext.Employees.FindAsync(id) ?? throw new Exception("Employee is not found");
        }

        public async Task<Employee> UpdateEmployee(int id, Employee updateRec)
        {
            var emp = await dbContext.Employees.FindAsync(id);
            if(emp == null)
            {
                throw new Exception("Employee not found to update");
            }
            else
            {
                emp.PhoneNo = updateRec.PhoneNo;
                emp.EmailAddress = updateRec.EmailAddress;
                emp.ImageFile   = updateRec.ImageFile;
                emp.EmpName = updateRec.EmpName;
                await dbContext.SaveChangesAsync();
                return await new Task<Employee>(() => emp);
            }
        }
    }
}