using Microsoft.EntityFrameworkCore;

namespace mysql
{
    class ApplicationDbContext : DbContext
    { 
        public DbSet<Data> Datas { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Error> Errors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;database=Loger;uid=root;pwd=raspberry");
        } 
    }
}