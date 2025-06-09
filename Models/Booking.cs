using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

public class Booking
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public string UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalPrice { get; set; }
    public BookingStatus Status { get; set; }

    public Car Car { get; set; }
    public IdentityUser User { get; set; }
}

public enum BookingStatus
{
    [Display(Name = "مؤكد")]
    Confirmed = 1,

    [Display(Name = "ملغي")]
    Cancelled = 2,

    [Display(Name = "مكتمل")]
    Completed = 3
}
