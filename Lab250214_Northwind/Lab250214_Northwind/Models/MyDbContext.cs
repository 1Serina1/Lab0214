using System.Collections.Generic;

namespace Lab250214_Northwind.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
