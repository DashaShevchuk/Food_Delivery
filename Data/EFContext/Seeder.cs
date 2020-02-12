using Food_Delivery.Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Data.EFContext
{
    public class Seeder
    {
        public static async void SeedRoles(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();

                var roleName1 = "Admin";
                var result = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName1
                }).Result;

                var roleName2 = "User";
                var result2 = managerRole.CreateAsync(new DbRole
                {
                    Name = roleName2
                }).Result;
            }
        }

        public static async void SeedUsers(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();

                var roleName1 = "Admin";
                var roleName2 = "User";

                UserProfile adminProfile = new UserProfile
                {
                    FirstName = "Dasha",
                    LastName = "Shevchuck"
                };
                DbUser admin = new DbUser
                {
                    Email = "77dasha0377gmail.com",
                    UserName = "sshevchuckaa",
                    UserProfile = adminProfile
                };
                var res = await manager.CreateAsync(admin, "Qwerty-1");
                res = manager.AddToRoleAsync(admin, roleName1).Result;

                UserProfile userProfile1 = new UserProfile
                {
                    FirstName = "Sasha",
                    LastName = "Ivanova"
                };
                DbUser user1 = new DbUser
                {
                    Email = "sasha@gmail.com",
                    UserName = "sashka",
                    UserProfile = userProfile1
                };
                var res1 = await manager.CreateAsync(user1, "Qwerty-1");
                res1 = manager.AddToRoleAsync(user1, roleName2).Result;

                UserProfile userProfile2 = new UserProfile
                {
                    FirstName = "Petia",
                    LastName = "Petrov"
                };
                DbUser user2 = new DbUser
                {
                    Email = "petia@gmail.com",
                    UserName = "petruk",
                    UserProfile = userProfile2
                };
                var res2 = await manager.CreateAsync(user2, "Qwerty-1");
                res2 = manager.AddToRoleAsync(user2, roleName2).Result;
            }
        }
        public static async void SeedCategories(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                Category category = new Category
                {
                    Name = "Макі"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Суші роли"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Теплі роли"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Філадельфія"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Суші"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Асорті та комбо"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Піца"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Wok"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Супи"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Салати"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Напої"
                };
                context.Categories.Add(category);
                category = new Category
                {
                    Name = "Додатки"
                };
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
