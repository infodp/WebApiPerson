using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
