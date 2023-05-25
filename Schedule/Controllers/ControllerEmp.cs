using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schedule.Context;
using Schedule.Models.ReferenceBooksModule;
using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ContingentModule;
using Schedule.Models.GeneralModule;
using Microsoft.EntityFrameworkCore;

namespace Schedule.Controllers
{
    public class ControllerEmp
    {
        private MainContext _dbContext;

        public ControllerEmp(MainContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetAllEMP()
        {
           return _dbContext.Employee.Include(e => e.Auditorium).ToList();
        }

        public void Add(Employee Employee)
        {
            _dbContext.Employee.Add(Employee);
            _dbContext.SaveChanges();
        }

        public void Update(Employee Employee)
        {
            _dbContext.Employee.Update(Employee);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var Employee = _dbContext.Employee.Find(id);
            if (Employee != null)
            {
                _dbContext.Employee.Remove(Employee);
                _dbContext.SaveChanges();
            }
        }
    }
}
