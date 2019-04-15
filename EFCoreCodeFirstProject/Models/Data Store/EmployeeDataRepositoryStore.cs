using EFCoreCodeFirstProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstProject.Models.Data_Store
{
    public class EmployeeDataRepositoryStore : IEmployeeDataRepository<Employee>
    {
        private EmployeeContext _context;

        public EmployeeDataRepositoryStore(EmployeeContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(long id)
        {
            return _context.Employees.FirstOrDefault(a => a.EmployeeId == id);
        }

        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.Email = entity.Email;
            employee.PhoneNumber = entity.PhoneNumber;
            employee.Gender = entity.Gender;

            _context.SaveChanges();
        }

        public void Add(Employee entity)
        {
            _context.Employees.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            _context.Employees.Remove(entity);
            _context.SaveChanges();
        }                                                                                                                             

    }
}
