using Microsoft.EntityFrameworkCore;
   
namespace EAP_Practice.Models
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext(DbContextOptions<EmpDBContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
