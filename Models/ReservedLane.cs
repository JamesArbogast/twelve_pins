using System.ComponentModel.DataAnnotations;
using twelve_pins.Models;
using System;

public class ReservedLane
{
    [Key]
    public int ReservedLaneId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int LaneId { get; set; }
    public Lane Lane { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}