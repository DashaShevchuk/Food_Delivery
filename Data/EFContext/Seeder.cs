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
        public static async void SeedProducts(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                Product product = new Product
                {
                    Name = "Рол Макі Чука",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-74-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Салат чука",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з огірком",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-71-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Огірок, конжут",
                    Price = 45,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-70-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Лосось",
                    Price = 69,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з гострим лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-69-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Лосось, соус спайсі",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з гострою креветкою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-66-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Креветка, соус спайсі",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з авокадо",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-68-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Авокадо",
                    Price = 55,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з гострою куркою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-67-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Копчена курка, соус спайсі, кунжут",
                    Price = 65,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з гострим тунцем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-65-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Тунець, соус спайсі",
                    Price = 82,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з беконом",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-64-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Бекон, зелена цибуля",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з вугрем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-63-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Вугор, соус унагі, кунжут",
                    Price = 79,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі філа ікура",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-61-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Філадельфія, червона ікра",
                    Price = 65,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з тунцем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-62-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Тунець",
                    Price = 81,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі томато",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-60-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Помідор",
                    Price = 45,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі з копченим лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-57-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Копчений лосось",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макі вакаба RED",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-55-s-300x200.jpg",
                    Weight = 110,
                    Ingredients = "Болгарський перець червоний",
                    Price = 45,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 1
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
