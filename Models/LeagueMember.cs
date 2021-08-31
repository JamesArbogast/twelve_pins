using System.ComponentModel.DataAnnotations;
using twelve_pins.Models;
using System;

public class LeagueMember
{
    [Key]
    public int LeagueMemberId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int LeagueId { get; set; }
    public League League { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}