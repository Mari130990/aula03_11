using Chapterturma9.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapterturma9.Contexts
{

    public class SqlContext : DbContext
    {

        public SqlContext(){}
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =DESKTOP-VG35NHF\\SQLEXPRESS; initial catalog = Chapter Integrated Security = true");

            }
        }
        public DbSet<Livro> Livros { get; set; }

        

    }
}
