using CascadingDropdownList.Models.Cascade;
using Microsoft.EntityFrameworkCore;

namespace CascadingDropdownList.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : 
            base(options) 
        {

        }
        public DbSet<Country> Countries { get; set; }   
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
