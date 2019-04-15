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

    [Route("api/profession")]
    [ApiController]
    public class ProfessionController : ControllerBase
    {
        private readonly IProfessionDataRepository<Profession> _dataRepository;

        public ProfessionController(IProfessionDataRepository<Profession> dataRepository)
        {
            _dataRepository = dataRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Profession> profession = _dataRepository.GetAll();
            return Ok(profession);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Profession profession = _dataRepository.GetById(id);

            if (profession == null)
            {
                return NotFound("The Profession record couldn't be found.");
            }

            return Ok(profession);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Profession profession)
        {
            if (profession == null)
            {
                return BadRequest("Profession is null.");
            }
            _dataRepository.Add(profession);

            return CreatedAtRoute("GET", new { Id = profession.ProfessionId }, profession);
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Profession profession)
        {
            if (profession == null)
            {
                return BadRequest("Employee is null");
            }

            Profession professionToUpdate = _dataRepository.GetById(id);
            if (professionToUpdate == null)
            {
                return BadRequest("The Employee record couldn't be found.");
            }
            if (profession != null)
            {
                _dataRepository.Update(professionToUpdate, profession);
                return StatusCode(200, "Successfully Updated");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            Profession profession = _dataRepository.GetById(id);
            if (profession == null)
            {
                return BadRequest("Profession doesn't exist");
            }

            _dataRepository.Delete(profession);

            return NoContent();

        }

    }
}