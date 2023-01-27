using Microsoft.AspNetCore.Identity;

namespace AWeatherAPI.Entities
{
   public class User : IdentityUser
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }

    }
}
