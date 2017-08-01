using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public short NumberInStock { get; set; }

    }
}