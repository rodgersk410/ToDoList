using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }


        public IConfigurationRoot Configuration { get; set; }
        public TodoContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath("C:\\Users\\Administrator\\Documents\\Visual Studio 2017\\Projects\\ToDoList\\ToDoList")
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Worker> Workers { get; set; }

    }
}