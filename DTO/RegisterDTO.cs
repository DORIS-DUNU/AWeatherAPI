using System.ComponentModel.DataAnnotations;

namespace AWeatherAPI.DTO
{
    public class RegisterDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; } 
        [Required]
        public string Password { get; set; }

    }
}
