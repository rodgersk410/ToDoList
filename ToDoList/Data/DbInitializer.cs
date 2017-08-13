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

            var listItems = new TodoItem[]
            {
            new TodoItem{Name="Keith",IsComplete=true},
            new TodoItem{Name="Rodgers",IsComplete=false},
            new TodoItem{Name="Alexis",IsComplete=true},
            };
            foreach (TodoItem ti in listItems)
            {
                context.TodoItems.Add(ti);
            }
            context.SaveChanges();
        }
    }
}