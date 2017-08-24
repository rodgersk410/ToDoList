using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime DueDate { get; set; }
        public long WorkerId { get; set; }

        public Worker Worker { get; set; }
    }
}