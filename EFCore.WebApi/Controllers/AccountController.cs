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

    public class AccountController : ControllerBase
    {
        public readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }


        // GET: api/Account
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

        // GET: api/Account/5 
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Account
        public ActionResult Post(Account value)
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


        // PUT: api/Account/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
        }

    }
}
