using System.ComponentModel.DataAnnotations;

namespace FinalExam.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the model")]
        public string Model { get; set; }

        public int? Mileage { get; set; }
    }
}
