using Microsoft.AspNetCore.Identity;

namespace Nokosha.Models
{
        public class ApplicationUser : IdentityUser
        {

            public DateTime CreatedAt { get; set; } = DateTime.Now;

            public string RegisteredAs { get; set; } = string.Empty;
        }
    }

