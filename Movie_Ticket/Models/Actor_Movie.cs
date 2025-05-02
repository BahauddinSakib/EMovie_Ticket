using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Actor_Movie
    {
        [Key]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int ActorId { get; set; }

        public Actor Actor {  get; set; }

        //Relationship
       // public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
