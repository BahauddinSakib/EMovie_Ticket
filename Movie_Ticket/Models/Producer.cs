using Movie_Ticket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }  //unique identifie

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]

        public string Bio { get; set; }

        //Relationship

        public List<Movie> Movies { get; set; }
    }
}
