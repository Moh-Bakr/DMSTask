using DmsTask.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DmsTask.Provider
{
    public class ItContext : DbContext,IItContext
    {
        
        public ItContext(DbContextOptions<ItContext> context):base(context)
        {
            
        }

        

        public DbSet<Printer> Printers { set; get; }
        public DbSet<Laptop> Laptops { get; set; }

        public void complete()
        {

            
        }
    }
}
