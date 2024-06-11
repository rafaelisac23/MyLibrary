using Microsoft.EntityFrameworkCore;
using MyLibrary.Models; //para usar o DbContext precisa do using

namespace MyLibrary.Context
{
    public class MyLibraryContext : DbContext
    {
        public MyLibraryContext(DbContextOptions<MyLibraryContext>options ) :base (options)
        {
            
        }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Loan>? Loans { get; set; }
        public DbSet<Publisher>? Publishers{ get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
