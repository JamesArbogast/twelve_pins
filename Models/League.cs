using System;
using System.ComponentModel.DataAnnotations;

namespace twelve_pins.Models
  {
    public class League
    {
      [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
      public int LeagueId { get; set; }

      [Required(ErrorMessage = "is required")]
      [MinLength(2, ErrorMessage = "must be at least 2 characters")]
      [Display(Name = "Name")]
      public string Name { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Start Date")]
      public DateTime StartDate { get; set; }

      [Required(ErrorMessage = "is required")]
      [MinLength(5, ErrorMessage = "must be at least 5 characters")]
      [Display(Name = "Description")]
      public string Description { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.Now;
      public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
  }