using System;
using System.Collections.Generic;
using System.Text;
namespace EFCore.WebApi
{
    public class Person
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdDocument { get; set; }
        //public List<Account> Accounts { get; set; }

    }
}