using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        private string _genre = "";
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                short genreNumber;

                bool result = Int16.TryParse(value, out genreNumber);

                if (result)
                {
                    Genres.TryGetValue(genreNumber, out _genre);
                }
                else
                {
                    _genre = value;
                }
                
            }

        }

        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public short NumberInStock { get; set; }

        public Dictionary<int, string> Genres = new Dictionary<int, string>()
        {
            {1, "Action"},
            {2, "Adventure"},
            {3, "Anime"},
            {4, "Comedy"},
            {5, "Drama"},
            {6, "Historical"},
            {7, "Horror"},
            {8, "Musical"},
            {9, "Mystery"},
            {10, "Romance"},
            {11, "Science Fiction"}
        };

    }
}