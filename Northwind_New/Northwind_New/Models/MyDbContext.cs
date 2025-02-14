using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind_New.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
