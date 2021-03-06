﻿using System;
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
    public class TransactionController : ControllerBase
    {

        public readonly DataContext _context;
        public TransactionController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Transaction
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Transaction/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Transaction
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Transaction/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Transaction/5
        public void Delete(int id)
        {
        }
    }
}
