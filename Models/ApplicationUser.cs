using Microsoft.AspNetCore.Identity;

namespace ToddlerActivityPlanner.Models;

public class ApplicationUser : IdentityUser
{
    public string ParentName { get; set; } = "";
    public string AvatarPath { get; set; } = "/images/baby.jpeg";
}