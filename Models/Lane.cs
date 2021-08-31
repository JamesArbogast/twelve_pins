using System;
using System.ComponentModel.DataAnnotations;

namespace twelve_pins.Models
  {
    public class Lane
    {
      [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
      public int LaneId { get; set; }

      [Required(ErrorMessage = "is required")]
      [MinLength(2, ErrorMessage = "must be at least 2 characters")]
      [Display(Name = "Lane Number")]
      public int LaneNumber { get; set; }

      [Display(Name = "Bumper Required")]
      public bool BumperRequired { get; set; }

    }
  }