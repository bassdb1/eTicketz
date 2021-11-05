using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Models
{
    public class Actor
    {
        // Unique Key for Actor Class
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string  FullName { get; set; }
        public string Bio { get; set; }

        //Relationships - add this property with a name 'Actors_Movies'
        // Looks like <Actor_Movie> refers to the 'Actor_Movie' Model/Table??

        // ** '1 to Many Relationship' from 'Actor Table' with the 'Actors_Movies' table **
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
