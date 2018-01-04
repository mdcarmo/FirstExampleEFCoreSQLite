using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public int YearCreation { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
