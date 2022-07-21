using Microsoft.EntityFrameworkCore;

namespace todolist.Models
{
    public class DatabaseContextList : DbContext
    {
        public DatabaseContextList(DbContextOptions<DatabaseContextList> options) : base(options)
        {

        }
        public DbSet<Items> items { get; set; }


    }
}
