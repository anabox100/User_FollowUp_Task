using Microsoft.AspNetCore.Identity;

namespace User_FollowUp_Task.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    // Add new fields for Name and ID Number
    public string Name { get; set; } = string.Empty;
    public string IdNumber { get; set; } = string.Empty;
}