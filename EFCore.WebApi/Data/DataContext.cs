
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.WebApi
{
    public class DataContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=qwe123;Persist Security Info=True;User ID=sa;Initial Catalog=apiwebtest;Data Source=DESKTOP-S18LCON");
        }
    }
}