using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Add(Employee entity)
        {
            using ExampleContext context = new ExampleContext();    
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            using ExampleContext context = new ExampleContext();
            context.Employees.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            using ExampleContext context = new ExampleContext();
            return context.Employees.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            using ExampleContext context = new ExampleContext();
            context.Employees.Update(entity);
            context.SaveChanges();
        }
    }
}
