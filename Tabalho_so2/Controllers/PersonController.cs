using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Trabalho_so2.Model;
using Trabalho_so2.Services;

namespace Trabalho_so2.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
      

            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {


               var person = _personService.FindById(id);
            if(person == null) return NotFound();
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {


           
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {



            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));

            [HttpDelete]
            public IActionResult Delete(long id)
            {


            _personService.Delete(id);
            
            return NoContent();
        }



    }
}