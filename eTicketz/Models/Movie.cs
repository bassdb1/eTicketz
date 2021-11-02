using eTicketz.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Models
{
    public class Movie
    {
     
        [Key] // Data Anotation 
     // Primary Key ID for Movie Class Table
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }

        public Double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string CinamaName { get; set; }

        public MovieCategory MovieCategory { get; set; }








    }
}
