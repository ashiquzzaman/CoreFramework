using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoreFramework.Entities.Identities
{
      public class ApplicationUser : IdentityUser<int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
{
    public ApplicationUser(){}
    public ApplicationUser(string name) : this() { UserName = name; }
}
}