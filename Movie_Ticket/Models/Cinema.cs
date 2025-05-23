﻿using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }  //unique identifie

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
