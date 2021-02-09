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
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        public readonly DataContext _context;
        public PersonController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Person
        public ActionResult Get()
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

        // GET: api/Person/5 
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Person
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
