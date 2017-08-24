using TodoApi.Models;
using System;
using System.Linq;

namespace TodoApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var workers = new Worker[] 
            {
                new Worker { Name = "Jimbo", Age = 35 },
                new Worker { Name = "Jones", Age = 34 },
                new Worker { Name = "Nelson", Age = 33 },
                new Worker { Name = "Muntz", Age = 32 }
            };

            foreach (Worker w in workers)
            {
                context.Workers.Add(w);
            }
            context.SaveChanges();

            var listItems = new TodoItem[]
            {
            new TodoItem{Name="Keith",IsComplete=true,EnrollmentDate=DateTime.Today,DueDate=DateTime.Today,
                            WorkerId = workers.Single( s => s.Name == "Jimbo").WorkerId},
            new TodoItem{Name="Rodgers",IsComplete=false,EnrollmentDate=DateTime.Today,DueDate=DateTime.Today,
                            WorkerId = workers.Single( s => s.Name == "Jones").WorkerId},
            new TodoItem{Name="Alexis",IsComplete=true,EnrollmentDate=DateTime.Today,DueDate=DateTime.Today,
                            WorkerId = workers.Single( s => s.Name == "Nelson").WorkerId},
            new TodoItem{Name="Gabriel",IsComplete=true,EnrollmentDate=DateTime.Today,DueDate=DateTime.Today,
                            WorkerId = workers.Single( s => s.Name == "Muntz").WorkerId}
            };
            foreach (TodoItem ti in listItems)
            {
                context.TodoItems.Add(ti);
            }
            context.SaveChanges();
        }
    }
}