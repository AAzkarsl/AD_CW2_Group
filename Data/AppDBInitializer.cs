using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ebook_cw.Data.Static;
using ebook_cw.Models;


namespace ebook_cw.Data
{
    public class AppDBInitializer
    {

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var rolemanager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await rolemanager.RoleExistsAsync(UserRoles.Admin))
                    await rolemanager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await rolemanager.RoleExistsAsync(UserRoles.User))
                    await rolemanager.CreateAsync(new IdentityRole(UserRoles.User));

                //users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var adminUser = await userManager.FindByEmailAsync("admin@ebook.lk");
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FirstName = "Admin",
                        LastName = "EBook",
                        UserName = "admin",
                        Email = "admin@ebook.lk",
                        EmailConfirmed = true,
                        PhoneNumber = "0766695474",
                        PhoneNumberConfirmed = true

                    };
                    await userManager.CreateAsync(newAdminUser, "Ebook@1234");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

            }
        }
    }
}





