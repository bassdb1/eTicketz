using eTicketz.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Description { get; set; }

        public Double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string CinamaName { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships

        // The List of the Actors Movies - with a property name of 'Actors_Movies'
        // <Actor_Movie> looks to be referencing the <Actor_Movie> Model/Table
        // .. 'Movie Model/Table' seems to have a 1 to many relationship with 'Actor_Movies Table'
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Then we have a '1 to Many Relationship' with the Cinema

        //Cinema

        // Also need to define the Foreign Key - CinemaId

        public int CinemaID { get; set; } // --CinemaID id the FK for 'Cinema' Model Below.

        [ForeignKey("CinemaID")] // - Adding FK using 'Data Annotation' -Optional 

        // I say 'Optional' because the 'Entity Framework' will assume, that CinemaID = FK
        // However, we can also use 'Data Annotation' to declare the FK.  
        public Cinema Cinema { get; set; } // -- 'Cinema' Model/Table

        // Then we have a '1 to Many Relationship' with the Producer

        // Producer - Relationship - similar to the Cinema without as much comments
        public int ProducerID { get; set; } // - Foreign Key
        [ForeignKey("ProducerID")]

        public Producer Producer { get; set; }

    }
}
