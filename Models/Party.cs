using System;
using System.ComponentModel.DataAnnotations;

namespace twelve_pins.Models
  {
    public class Party
    {
      [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
      public int PartyId { get; set; }

      [Required(ErrorMessage = "is required")]
      [MinLength(2, ErrorMessage = "must be at least 2 characters")]
      [Display(Name = "First Name")]
      public string FirstName { get; set; }

      [Required(ErrorMessage = "is required")]
      [MinLength(2, ErrorMessage = "must be at least 2 characters")]
      [Display(Name = "Last Name")]
      public string LastName { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Phone Number")]
      [DataType(DataType.PhoneNumber)]
      public string PhoneNumber { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Email Address")]
      [DataType(DataType.EmailAddress)]
      public string Email { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Start Date")]
            [DataType(DataType.Date)]
      public DateTime PartyDate { get; set; }

      [Required(ErrorMessage = "is required")]
      [Display(Name = "Type of Party")]
      public String PartyType { get; set; }

      [Display(Name = "Bumper Required")]
      public bool BumperRequired { get; set; }

      [MinLength(5, ErrorMessage = "must be at least 5 characters")]
      [Display(Name = "Comments")]
      public string Comments { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.Now;
      public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
  }