using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CameraBazar.Data.Models
{
    public class User : IdentityUser
    {
        public List<Camera> Cameras { get; set; } = new List<Camera>();
    }
}
