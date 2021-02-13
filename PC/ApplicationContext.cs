using System.Data.Entity;
using PC.Model;

namespace PC
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }

        public DbSet<Medicine> Information { get; set; }
    }
}