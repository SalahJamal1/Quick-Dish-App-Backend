using Microsoft.AspNetCore.Identity;

namespace FoodApplication.Data;

public class ApiUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}