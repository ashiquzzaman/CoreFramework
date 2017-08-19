using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
namespace CoreFramework.Entities.Identities
{
public class ApplicationRole : IdentityRole<int>
{
    public ApplicationRole()
    {
    }
    public ApplicationRole(string name) : this() { Name = name; }
}
}