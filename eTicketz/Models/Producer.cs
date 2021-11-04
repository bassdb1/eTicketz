using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Models
{
    public class Producer
    {
        // Unique Key for Producer Class
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships - Property of type 'List'
        // We said the producer can have multiiple Movies, 
        // going to rename from 'MyProperty' to Movies
        //.. example, of default values of a property-> public int MyProperty { get; set; }
        // list = data type, 'Movies' = Property Name

        public List<Movie> Movies  { get; set; }
    }
}
