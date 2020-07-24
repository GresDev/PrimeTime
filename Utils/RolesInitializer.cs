using Microsoft.AspNetCore.Identity;

namespace PrimeTime.Utils
{
    public class RolesInitializer
    {
        public static void Initialize(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminName = "Admin";
            string adminEmail = "admin@maildomain.org";
            string adminPassword = "asdASD123!@#";
            string adminRole = "Administrator";
            string superUserRole = "SuperUser";
            string memberRole = "Member";


            if (roleManager.FindByNameAsync(adminRole).Result == null)
            {
                IdentityResult _ = roleManager.CreateAsync(new IdentityRole(adminRole)).Result;
            }

            if (roleManager.FindByNameAsync(superUserRole).Result == null)
            {
                IdentityResult _ = roleManager.CreateAsync(new IdentityRole(superUserRole)).Result;
            }

            if (roleManager.FindByNameAsync(memberRole).Result == null)
            {
                IdentityResult _ = roleManager.CreateAsync(new IdentityRole(memberRole)).Result;
            }

            if (userManager.FindByNameAsync(adminName).Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = adminName,
                    Email = adminEmail
                };

                IdentityResult result = userManager.CreateAsync(user, adminPassword).Result;

                if (result.Succeeded)
                {
                    IdentityResult _ = userManager.AddToRoleAsync(user, adminRole).Result;
                }
            }
        }
    }
}
