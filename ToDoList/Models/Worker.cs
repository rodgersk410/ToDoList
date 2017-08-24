using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Worker
    {
        public long WorkerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}