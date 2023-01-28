using System.ComponentModel.DataAnnotations;

namespace AWeatherAPI.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
