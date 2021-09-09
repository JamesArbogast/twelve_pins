using System;
using System.ComponentModel.DataAnnotations;

namespace twelve_pins.Models
  {
    public class Lane
    {
      [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
      public int LaneId { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Lane Number")]
      public int LaneNumber { get; set; }
    }
  }