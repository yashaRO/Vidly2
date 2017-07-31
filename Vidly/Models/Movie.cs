using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public int Id = 0;

        public Movie(string name)
        {
            Name = name;
            Id = ++Id;
        }
    }
}