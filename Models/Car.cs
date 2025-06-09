using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models 
{
    public enum CarStatus
    {
        [Display(Name = "متاحة")]
        Available = 1,
        [Display(Name = "محجوزة")]
        Booked = 2,
        [Display(Name = "معطلة")]
        OutOfService = 3
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public CarStatus Status { get; set; }
    }
}
