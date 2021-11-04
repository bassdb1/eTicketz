using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Models
{
    public class Cinema
    {
        // Unique Key for Cinema Class

        [Key]
        public int Id { get; set; }
        public string  Logo { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }

        //Relationships - Property - Using a 'List (Array) Data Type
        public List<Movie> Movies { get; set; }
    }
}
