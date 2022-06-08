using DmsTask.Provider;
using Microsoft.EntityFrameworkCore;

namespace DmsTask.Abstract
{
    public interface IItContext
    {
        public DbSet<Printer> Printers { set; get; }
        public DbSet<Laptop> Laptops { set; get; }
     
    }
}
