using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
    public class CardsDbContext: DbContext
    {
        public CardsDbContext(DbContextOptions options): base(options)
        {

        }

        //DbSet
        // Acts as a table in SQLServer
        public DbSet<Card> Cards { get; set; }
    }
}
