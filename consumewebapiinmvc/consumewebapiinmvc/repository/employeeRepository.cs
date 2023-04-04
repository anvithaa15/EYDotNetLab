using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using consumewebapiinmvc.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace consumewebapiinmvc.repository
{
    public class employeeRepository : IemployeeRepository
    {
        private readonly SQLDbContext db = new SQLDbContext();
        public async Task Add(employee employee)
        {
            employee.Id = Guid.NewGuid().ToString();
            db.Employees.Add(employee);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<employee> GetEmployee(string id)
        {
            try
            {
                employee employee = await db.Employees.FindAsync(id);
                if (employee == null)
                {
                    return null;
                }
                return employee;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<employee>> GetEmployees()
        {
            try
            {
                var employees = await db.Employees.ToListAsync();
                return employees.AsQueryable();
            }
            catch
            {
                throw;
            }
        }
        public async Task Update(employee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                employee employee = await db.Employees.FindAsync(id);
                db.Employees.Remove(employee);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        private bool EmployeeExists(string id)
        {
            return db.Employees.Count(e => e.Id == id) > 0;
        }
    }
}