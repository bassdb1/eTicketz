using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Models
{
    public class Actor_Movie
    {
        // This Model/table will store our 'MovieId' and 'ActorId' for the many to many relationship
        public int MovieId { get; set; } // -- MovieID id the FK for 'Movie' Model Below.
        public Movie Movie { get; set; } // -- 'Movie' Model/Table

        public int ActorId { get; set; } // -- ActorID id the FK for 'Actor' Model Below.
        public Actor Actor { get; set; } // -- 'Actor' Model/Table
    }
}
