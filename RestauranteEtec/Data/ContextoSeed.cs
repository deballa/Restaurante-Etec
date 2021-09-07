using Microsoft.AspNetCore.Identity;
using RestauranteEtec.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Data
{
    public class ContextoSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Moderador.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Basico.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "deballa",
                Email = "deborah.balla@gmail.com",
                NomeCompleto = "Déborah Ballaminut de Lacerda",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "@Etec123");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basico.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Moderador.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.SuperAdmin.ToString());
                }
            }
        }
    }
}
