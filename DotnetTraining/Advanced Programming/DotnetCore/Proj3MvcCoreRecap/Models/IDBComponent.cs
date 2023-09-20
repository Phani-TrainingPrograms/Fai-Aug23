namespace Proj3MvcCoreRecap.Models
{
    public interface IDBComponent
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
        Employee GetEmployee(int id);
        List<Dept> GetAllDepts();
        Dept GetDept(int id);
    }

    public class DBComponent : IDBComponent
    {
        private readonly MyDbContext _dbContext;
        public DBComponent(MyDbContext context)
        {
            _dbContext = context;
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.EmpTables.Add(employee);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var selected = _dbContext.EmpTables.Find(id);
            if (selected != null)
            {
                _dbContext.EmpTables.Remove(selected);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("No Record found to delete");
            }
        }

        public List<Dept> GetAllDepts()
        {
            return _dbContext.DeptTables.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.EmpTables.ToList();
        }

        public Dept GetDept(int id)
        {
            return _dbContext.DeptTables.Find(id) ?? throw new Exception("Dept not found");
        }

        public Employee GetEmployee(int id)
        {
            return _dbContext.EmpTables.Find(id) ?? throw new Exception("Employee not found");
        }

        public void UpdateEmployee(Employee employee)
        {
            var emp = _dbContext.EmpTables.Find(employee.Id);
            if (emp != null)
            {
                emp.Salary = employee.Salary;
                emp.Address = employee.Address;
                emp.Name = employee.Name;
                emp.DeptId = employee.DeptId;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to update");
            }
        }
    }
}
