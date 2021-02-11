using System;
using System.Collections.Generic;
using System.Text;
namespace EFCore.WebApi
{
    public class Account
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public int AccNumber { get; set; }
        public string Password { get; set; }
       // public List<Transaction> Transactions{ get; set; }

    }
}