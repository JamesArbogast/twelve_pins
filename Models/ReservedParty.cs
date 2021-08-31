using System.ComponentModel.DataAnnotations;
using twelve_pins.Models;
using System;

public class ReservedParty
{
    [Key]
    public int ReservedPartyId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int PartyId { get; set; }
    public Party Party { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}