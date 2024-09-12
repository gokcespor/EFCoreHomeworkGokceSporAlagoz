using EFCoreHomeworkGokceSporAlagoz.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomeworkGokceSporAlagoz.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=EFCoreHomeworkGokce;uid=sa;pwd=1234;trustservercertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
