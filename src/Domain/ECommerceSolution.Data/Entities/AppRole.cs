using Microsoft.AspNetCore.Identity;

namespace ECommerceSolution.Data.Entities;
public class AppRole : IdentityRole<Guid>
{
    public string Description { get; set; }
}