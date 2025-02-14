namespace Lab250214_Northwind.Models
{
    public class DbContext
    {
        private DbContextOptions<MyDbContext> options;

        public DbContext(DbContextOptions<MyDbContext> options)
        {
            this.options = options;
        }
    }
}