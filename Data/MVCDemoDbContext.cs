using EmployeeS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeS.Data
{
    public class MVCDemoDbContext : DbContext
    {
       
        public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employee1 { get; set; }
    }

}
