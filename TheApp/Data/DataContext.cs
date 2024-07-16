using Microsoft.EntityFrameworkCore;
using TheApp.Models;

namespace TheApp.Data
{
    public class DataContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> Persons { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlite("DemoDb.db");

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=mydb.db");
        //    SQLitePCL.Batteries.Init();
        //}

        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{
           
        //}
    }
}
