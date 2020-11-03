using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        //private const string ConnectionString = @"Server=EDI-PC\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EDI-PC\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;"); 
        }

        //Write "Add-Migration Initial" in Package Manager Console
        //After that you have to execute: Update-Database
        //After this you should be able to find your database with Tasks table in SSMS.
    }
}
