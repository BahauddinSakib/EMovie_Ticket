using Movie_Ticket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }  //unique identifie

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biograpgy is Required")]

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; } //Navigation property
    }
}
