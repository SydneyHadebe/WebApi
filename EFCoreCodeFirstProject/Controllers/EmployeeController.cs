using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreCodeFirstProject.Models;
using EFCoreCodeFirstProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreCodeFirstProject.Controllers
{
   [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDataRepository<Employee> _dataRepository;

        public EmployeeController(IEmployeeDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.GetById(id);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }
            _dataRepository.Add(employee);

            return CreatedAtRoute("GET", new { Id = employee.EmployeeId }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null");
            }

            Employee employeeToUpdate = _dataRepository.GetById(id);
            if (employeeToUpdate == null)
            {
                return BadRequest("The Employee record couldn't be found.");
            }
            if (employee != null)
            {
                _dataRepository.Update(employeeToUpdate, employee);
                return StatusCode(200, "Successfully Updated");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.GetById(id);
            if (employee == null)
            {
                return BadRequest("Employee doesn't exist");
            }

            _dataRepository.Delete(employee);

            return NoContent();

        }

    }
}