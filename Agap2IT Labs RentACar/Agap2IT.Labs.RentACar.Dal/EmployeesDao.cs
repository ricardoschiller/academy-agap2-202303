using Agap2IT.Labs.RentACar.Data.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Dal
{
    public class EmployeesDao
    {
        public void Add(Employee employee)
        {
            var context = new Academy202303Context();

            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            var context = new Academy202303Context();

            context.Employees.Update(employee);
            context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            var context = new Academy202303Context();

            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        public Employee Get(int id)
        {
            var context = new Academy202303Context();
            return context.Employees.Where(e => e.Id == id).SingleOrDefault();
        }

        public List<Employee> GetAll()
        {
            var context = new Academy202303Context();
            return context.Employees.ToList();
        }
    }
}
