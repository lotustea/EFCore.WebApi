using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EFCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        public readonly DataContext _context;
        public PersonController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Person
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var person = new Person
                {
                    Nome = "Luís Gustavo Peixoto Júnior",
                    BirthDate = new DateTime(1997, 6, 15),
                    IdDocument = "6118449121"
                };

                _context.Persons.Add(person);
                _context.SaveChanges();

                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest($"ERRO: {ex}");
            }
        }

        // GET: api/Person/5 
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Person
        [HttpPost]
        public ActionResult Post(Person value)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest($"ERRO: {ex}");
            }
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]string value)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest($"ERRO: {ex}");
            }
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest($"ERRO: {ex}");
            }
        }
    }
}
