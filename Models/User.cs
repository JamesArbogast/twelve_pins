using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace twelve_pins.Models
  {
      public class User
      {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int UserId { get; set; }
        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Last Name")]
        public string Email { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(5, ErrorMessage = "must be at least 5 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<League> Leagues { get; set; }
        public List<Lane> Lanes { get; set; }
        public List<Party> Parties { get; set; }
      }
  }
