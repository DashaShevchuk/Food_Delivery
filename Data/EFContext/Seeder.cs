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

                product = new Product
                {
                    Name = "Рол Джедай",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2020/01/DSCF6454-Recovered-2-300x200.jpg",
                    Weight = 225,
                    Ingredients = "Сир філадельфія, криветка в клярі, лосось, тунець, вугор, соус спайсі",
                    Price = 185,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Фелікс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2020/01/DSCF6454-Recovered-1-300x200.jpg",
                    Weight = 250,
                    Ingredients = "Лосось, соус щирячі, кляр, сир тостовий, соус спайсі, зелена цибуля",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Золотий Дракон",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/03/unagi-fila_PNG-300x200.png",
                    Weight = 200,
                    Ingredients = "Філадельфія, вугор, соус унагі, кунжут білий",
                    Price = 145,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Боніто Сякі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/395833-405-336-bonto_syak-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Сир філадельфія, томат, стружка тунця, огірок, ікра масаго, лосось теріякі",
                    Price = 73,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Хот сякі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/395841-405-336-hot_syak-300x200.jpg",
                    Weight = 190,
                    Ingredients = "Зелена цибуля, сир філадельфія, кунжут, соус",
                    Price = 78,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Футумакі з копченим лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/395831-405-336-futomak_z_kopchenim_lososem-300x200.jpg",
                    Weight = 165,
                    Ingredients = "Копчений лосось, соус спайсі, огірок",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Кані чіз",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/395829-405-336-kan_chz-300x200.jpg",
                    Weight = 195,
                    Ingredients = "Сир філадельфія, кунжут, огірок, сніжний краб",
                    Price = 82,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Ебі тай",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/395825-405-336-eb_taj-300x200.jpg",
                    Weight = 195,
                    Ingredients = "Сир філадельфія, кунжут, соус спайсі, огірок, криветка",
                    Price = 93,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Камікадзе",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/dsfds123-300x200.jpg",
                    Weight = 185,
                    Ingredients = "Вугор, філадельфія, ікра масаго, огірок, зелена цибуля, стружка тунця",
                    Price = 157,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Боніто",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/123456aaa.png-300x200.png",
                    Weight = 180,
                    Ingredients = "Копчений лосось, філадльфія, стружка тунця",
                    Price = 137,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Хакамото",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-42-s-300x200.jpg",
                    Weight = 205,
                    Ingredients = "Креветки, окунь, авокадо, омлет, масаго",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Катемако",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-36-s-300x200.jpg",
                    Weight = 205,
                    Ingredients = "Бекон, помідор, куряче яйце, соус спайсі, стружка тунця",
                    Price = 79,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Фреш з вугрем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-41-s-300x200.jpg",
                    Weight = 185,
                    Ingredients = "Вугор, айсберг, огірок, японський майонез",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Флеш",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-40-s-300x200.jpg",
                    Weight = 215,
                    Ingredients = "Лосось, авокадо, омлет, японський майонез, масаго",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Сякі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-39-s-300x200.jpg",
                    Weight = 220,
                    Ingredients = "Лосось, філадельфія",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Сахара",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-38-s-300x200.jpg",
                    Weight = 220,
                    Ingredients = "Сніжний краб, філадельфія, огірок, помідор, омлет",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Окінава",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-37-s-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Сніжний краб, огірок, омлет, японський майонез, масаго",
                    Price = 85,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Амай",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-33-s-300x200.jpg",
                    Weight = 225,
                    Ingredients = "Лосось, помідор, японський майонез, омлет, філадельфія",
                    Price = 119,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Дракон",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-35-s-300x200.jpg",
                    Weight = 250,
                    Ingredients = "Вугор, філадельфія, огірок, масао, соус унагі, кунжут",
                    Price = 165,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Каліфорнія з тунцем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-32-s-300x200.jpg",
                    Weight = 165,
                    Ingredients = "Тунець, соус спайсі, кунжут",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Веган",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-34-s-300x200.jpg",
                    Weight = 165,
                    Ingredients = "Перець болгарський, помідор, авокадо, айсберг, японський майонез",
                    Price = 59,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Каліфорнія з лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-30-s-300x200.jpg",
                    Weight = 165,
                    Ingredients = "Лосось, соус спайсі, кунжут",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Каліфорнія з вугрем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-29-s-300x200.jpg",
                    Weight = 165,
                    Ingredients = "Вугор, спайсі, кунжут",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Фудзіяма",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-27-s-300x200.jpg",
                    Weight = 245,
                    Ingredients = "Сніжний краб, огірок, авокадо, філадельфія, масаго, спайсі соус",
                    Price = 89,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Фреш Краб",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-26-s.jpg",
                    Weight = 200,
                    Ingredients = "Сніжний краб, айсберг, масаго, соус спайсі",
                    Price = 89,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Тері",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-23-s.jpg",
                    Weight = 220,
                    Ingredients = "Лосось теріякі, айсберг, огірок, філадельфія, масаго",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Кайф",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-24-s.jpg",
                    Weight = 235,
                    Ingredients = "Вугор, курка копчена, авокадо, філадельфія, масаго, кунжут",
                    Price = 135,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Лео",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-21-s.jpg",
                    Weight = 235,
                    Ingredients = "Сніжний краб, креветки, авокадо, філадельфія, масаго, кунжут",
                    Price = 141,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Ебі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-20-s-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Креветки, філадельфія, масаго",
                    Price = 129,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Торонто",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-17-s.jpg",
                    Weight = 240,
                    Ingredients = "Лосось теріякі, айсберг, помідор, філадельфія, спайсі соус, кунжут, масаго",
                    Price = 120,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Вега",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-18-s.jpg",
                    Weight = 255,
                    Ingredients = "Айсберг, огірок, авокадо, перець болгарський, японський майонез",
                    Price = 69,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Фараон",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-16-s.jpg",
                    Weight = 235,
                    Ingredients = "Курка копчена, огірок, філадельфія, масаго, цибуля зелена, кунжут",
                    Price = 119,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Холі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-14-s.jpg",
                    Weight = 260,
                    Ingredients = "Сніжний краб, креветка коктейльна, огірок, авокадо, японський майонез, ікра",
                    Price = 129,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Королівський",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-11-s.jpg",
                    Weight = 250,
                    Ingredients = "Лосось теріякі, філадельфія, огірок, помідор, перець болгарський, стружка",
                    Price = 131,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Лава",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-13-s.jpg",
                    Weight = 220,
                    Ingredients = "Вугор, курка копчена, огірок",
                    Price = 139,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Хвиля",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-10-s.jpg",
                    Weight = 225,
                    Ingredients = "Лосось, криветка, авокадо, філадельфія, лимон",
                    Price = 169,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Аляска",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-8-s-300x200.jpg",
                    Weight = 220,
                    Ingredients = "Лосось, огірок, авокадо, масао",
                    Price = 114,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Каліфорнія",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-9-s-300x200.jpg",
                    Weight = 220,
                    Ingredients = "Сніжний краб, огірок, японський майонез, кунжут",
                    Price = 55,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Дует",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-6-s-300x200.jpg",
                    Weight = 255,
                    Ingredients = "Лосось, криветки, філадельфія, огірок, авокадо, цибуля зелена, соус спайсі, кунжут",
                    Price = 137,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол з Беконом",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-5-s.jpg",
                    Weight = 230,
                    Ingredients = "Бекон, вугор, філадельфія, цибуля зелена, огірок, кунжут",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Блітс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-4-s-300x200.jpg",
                    Weight = 230,
                    Ingredients = "Лосось, червоний окунь, філадельфія, огірок, авокадо, масаго, кунжут",
                    Price = 110,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Япошка",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-3-s-300x200.jpg",
                    Weight = 235,
                    Ingredients = "Сніжний краб, чука, філадельфія, сир тостовий, кунжут, соус унагі",
                    Price = 71,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Бронзовй Дракон",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-2-s-300x200.jpg",
                    Weight = 215,
                    Ingredients = "Вугор, філадельфія, авокадо, соус унагі, кунжут",
                    Price = 159,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Кінг",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/112s.jpg",
                    Weight = 225,
                    Ingredients = "Лосось, огірок, філадельфія, ікра масаго",
                    Price = 137,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Сирний",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-110-202-300x200.jpg",
                    Weight = 250,
                    Ingredients = "Тофу, філадельфія, японський майонез, кунжут",
                    Price = 55,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Пачі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/100-1007-300x200.jpg",
                    Weight = 205,
                    Ingredients = "Окунь, помідор, японський омлет, японський майонез, ікра масаго",
                    Price = 72,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Макан",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1006-300x200.jpg",
                    Weight = 215,
                    Ingredients = "Японський млинець, філадельфія, ікра червона",
                    Price = 85,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Блек",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1005-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось копчений, філадельфія, курка копчена, ікра масаго",
                    Price = 126,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Футо Мікс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/futo_mix-300x200.jpg",
                    Weight = 275,
                    Ingredients = "Куряча копчена грудинка, бекон, айсберг, помідор, огірок, зелена цибуля, спайсі соус",
                    Price = 89,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Масаго Чіз",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1088-300x200.jpg",
                    Weight = 195,
                    Ingredients = "Філадельфія, тофу, ікра масаго",
                    Price = 77,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Батакон",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/100-103-3-300x200.jpg",
                    Weight = 180,
                    Ingredients = "Бекон, курка копчена, філадельфія, цибуля, кунжут",
                    Price = 69,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Чорний Самурай",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
                    Weight = 220,
                    Ingredients = "Лосось теріякі, філадельфія, огірок, цибуля зелена, масаго, кунжут",
                    Price = 107,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 2
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Веган",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/700-010-Темпура-веган-300x200.png",
                    Weight = 220,
                    Ingredients = "Авокадо, огірок, айсберг, помідор, японський майонез, кляр",
                    Price = 94,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Лайт",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/темпура_PNG-300x200.jpg",
                    Weight = 195,
                    Ingredients = "Курка копчена, огірок, айсберг, японський майонез, кляр",
                    Price = 106,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Гарячий Цезар",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/PNG-1-1-300x200.jpg",
                    Weight = 185,
                    Ingredients = "Курка копчена, помідор, соус Цезар, айсберг, кляр",
                    Price = 102,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Гранд",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/PNG-1-300x200.jpg",
                    Weight = 205,
                    Ingredients = "Лосось, авокадо, помідор, японський майонез, кляр",
                    Price = 136,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Хіт",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/2_PNG-1-1-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Лосось, вугор, авокадо, філадеьфія, кляр",
                    Price = 152,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Сякі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/PNG-300x200.png",
                    Weight = 195,
                    Ingredients = "Лосось теріякі, філадельфія, огірок, кляр",
                    Price = 106,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Дуос",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/2_PNG-1-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Лосось, креветка, огірок, соус Спайсі, кляр",
                    Price = 152,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Ебі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/tempura-ebi-300x200.png",
                    Weight = 200,
                    Ingredients = "Криветка, огірок, помідор, соус Спайсі",
                    Price = 136,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура копчений лосось",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/ролл-катана-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Лосось копчений, омлет, огірок, соус Спайсі, кляр",
                    Price = 94,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Темпура Чікен",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/12/700-001-Темпура-чікен-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Курка копчена, томат, омлет, унагі соус, кунжут, кляр",
                    Price = 117,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Сякі Дуо",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/filadelfia-duo_PNG-300x200.png",
                    Weight = 240,
                    Ingredients = "Лосось, філадельфія, огірок, авокадо",
                    Price = 165,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Філадельфія Мікс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/03/saketay_PNG-300x200.png",
                    Weight = 220,
                    Ingredients = "Курка копчена, омлет, помідор, лосось, Філадельфія",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Шок",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-53-s.jpg",
                    Weight = 225,
                    Ingredients = "Лосось, огірок, авокадо, масаго, філадельфія",
                    Price = 165,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Крабс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-52-s-300x200.jpg",
                    Weight = 235,
                    Ingredients = "Лосось, сніжний краб, авокадо, огірок, філадельфія",
                    Price = 149,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Класік",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-51-s-300x200.jpg",
                    Weight = 240,
                    Ingredients = "Лосось, філадельфія",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Унагі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-54-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, вугор, філадельфія",
                    Price = 170,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Ікура",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-48-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, червона ікра, філадельфія",
                    Price = 149,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Каппа",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-50-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, огірок, філадельфія",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Кані",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-49-s.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, сніжний краб, філадельфія",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Масаго",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-47-s.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, масаго, філадельфія",
                    Price = 145,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Гавайська",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-45-s.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, ананас, філадельфія",
                    Price = 138,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Ебі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-46-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, креветки, філадельфія",
                    Price = 155,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Авокадо",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-44-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Лосось, авокадо, філадельфія",
                    Price = 135,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рол Філадельфія Гінгер",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-43-s.jpg",
                    Weight = 220,
                    Ingredients = "Лосось, імбир, філадельфія, ікра масаго",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 4
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс філа тунець",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-96-s-300x200.jpg",
                    Weight = 45,
                    Ingredients = "Тунець, філадельфія",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс філа вугор",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-94-s-300x200.jpg",
                    Weight = 45,
                    Ingredients = "Вугор, філадельфія",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс філа креветка",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-95-s-300x200.jpg",
                    Weight = 45,
                    Ingredients = "Креветка, філадельфія",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс філа лосось",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-93-s-300x200.jpg",
                    Weight = 45,
                    Ingredients = "Лосось, філадельфія",
                    Price = 41,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс чука",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-92-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Салат чука, кунжут",
                    Price = 31,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс масаго",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-91-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Ікра масаго",
                    Price = 45,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс ікура",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-90-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Ікра червона",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс з тунцем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-88-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Тунець, соус спайсі",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс з сніжним крабом",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-89-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Сніжний краб, соус спайсі",
                    Price = 35,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс з креветкою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-85-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Креветка, соус спайсі",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Суші лосось",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-75-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Лосось",
                    Price = 29,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс з вугрем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-84-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Вугор, соус спайсі",
                    Price = 49,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Спайс з копченим лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-83-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Копчений лосось, соус спайсі",
                    Price = 41,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                product = new Product
                {
                    Name = "Спайс з лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-82-s-300x200.jpg",
                    Weight = 40,
                    Ingredients = "Лосось, соус спайсі",
                    Price = 41,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Суші тунець",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-81-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Тунець",
                    Price = 39,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Суші копчений лосось",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-76-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Копчений лосось",
                    Price = 33,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Суші вугор",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-77-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Вугор",
                    Price = 39,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Суші креветка",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-78-s-300x200.jpg",
                    Weight = 35,
                    Ingredients = "Креветка",
                    Price = 39,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 5
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Комбо Вега",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2020/02/kombovega-300x200.png",
                    Ingredients = "Місо, піца Вегетеріанська, Bonaqa негазована",
                    Price = 200,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Комбо 4",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2020/02/kombo356-300x200.png",
                    Weight = 0,
                    Ingredients = "Том Кха Торі, піца Салями, Coca-Cola",
                    Price = 240,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Комбо 1",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/kombo210-300x200.png",
                    Weight = 0,
                    Ingredients = "Рол сирний, Рол Боніто Сякі, Удон зі свининою, Coca-Cola",
                    Price = 210,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Комбо 2",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/kombo200-300x200.png",
                    Weight = 0,
                    Ingredients = "Рол сирний, Рол Каліфорнія, Піца Шинок, Coca-Cola",
                    Price = 200,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Комбо 3",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/kombo250-300x200.png",
                    Weight = 0,
                    Ingredients = "Рол Боніто Сякі, Рол Япошка, Піца Реджина, 2 Coca-Cola",
                    Price = 250,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Сирне",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/01/gggggggggg-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол сирний, Рол масаго чіз, Рол Філадельфія класік, Рол Філадельфія каппа",
                    Price = 349,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті 2 кіло",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/11/456456456-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол з беконом, Ебі тай, Сирний Каліфорнія, Боніто Сякі, Лео, Самурай, Кані чіз, Япошка",
                    Price = 599,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Сенсей",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-100-1-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Макі лосось (лосось); Рол Макі огірок (огірок, кунжут); Рол Філадельфія класік (лосось, філадельфія); Рол Амай (лосось, філадельфія, помідор, японський майонез, омлет); Рол Флеш (лосось, авокадо, японський майонез, омлет)",
                    Price = 475,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Суші",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-102-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Суші лосось 4 шт; Суші Вугор 4 шт; Суші Тунець 2 шт; Суші Креветка 2 шт",
                    Price = 387,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті МЕГА",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-101-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Макі з сніжним крабом (сніжний краб); Рол Макі філадельфія (філадельфія); Рол Макі огірок (огірок, кунжут); Рол Макі лосось (лосось); Рол Філадельфія Класік (лосось, філадельфія); Рол Хакамото (креветка, авокадо, омлет, окунь, масаго); Рол Дракон (вугор, філадельфія, огірок, масаго); Рол Катемако (бекон, яйце, свіжий помідор, спайсі соус, стружка тунця); Рол Фреш з Вугрем (вугор, айсберг, огірок, японський майонез, кунжут); Рол Сахара (сніжний краб, філадельфія, помідор, огірок, омлет)",
                    Price = 927,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Вега",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-98-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Макі огірок (огірок, кунжут); Рол Макі авокадо (авокадо); Рол Вакаба RED (перець болгарський червоний) ;Рол Маки чука (салат чука);Рол Макі томато (свіжий помідор)",
                    Price = 267,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Сякі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-99-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Половина Ролу Філадельфія сякі (лосось, філадельфія); Рол Макі лосось (лосось); Суші лосось3 шт (лосось)",
                    Price = 228,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті 2 2",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-97-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Макі філа ікура ( філадельфія, ікра червона); Рол Макі огірок (огірок, кунжут ); Рол Окінава ( сніжний краб, огірок, омлет, японський майонез, масаго); Рол Філадельфія Каппа (лосось, філадельфія, огірок)",
                    Price = 320,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Ото-ото",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/113s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Філадельфія Каппа ( лосось, огірок, філадельфія ); Рол Філадельфія Шок ( лосось, авокадо, ікра масаго, огірок, філадельфія); Рол Кінг ( лосось, огірок, філадельфія, ікра масаго); Рол Макі з огірком ( огірок, кунжут)",
                    Price = 455,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті 9 смаків",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1009-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Блек (копчений лосось, копчена курка, філадельфія, масаго); Рол Катемако ( бекон, помідор, яйце куряче, стружка тунця); Рол Амай ( лосось, помідор, японський майонез, млинець японський); Рол Макан ( філадельфія, ікра червона, млинець японський); Рол Флеш ( лосось, авокадо, японський омлет, японський майонез, масаго); Рол Філадельфія Сякі ( лосось, філадельфія); Рол Пачі (окунь, помідор, японський омлет, японський майонез, масаго); Рол Дракон ( вугор, філадельфія, огірок, масаго); Рол Окінава ( сніжний краб, огірок, японський омлет, японський майонез, масаго)",
                    Price = 975,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Лакшері",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-78-s-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Філадельфія Крабс ( лосось, сніжний краб, авокадо, огірок, філадельфія); Рол Чорний Самурай ( лосось теріякі, філадельфія, огірок, цибуля зелена, тобіко, кунжут); Рол Бронзовий Дракон ( вугор, філадельфія, авокадо, соус унагі, кунжут); Рол Фреш Крабс",
                    Price = 520,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Асорті Макет",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/meket-44a-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Рол Чорний Самурай ( лосось теріякі, філадельфія, огірок, зелена цибуля, ікра тобіко, кунжут); Рол Лава ( вугор, куряча грудинка копчена, айсберг, огірок, спайсі соус, унагі соус, кунжут); Рол з Беконом ( бекон копчений, вугор, філадельфія, зелена цибуля; Рол Тері (лосось теріякі, айсберг, огірок, сир Філадельфія, ікра Масаго)",
                    Price = 200,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 6
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Грибна",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/412-201-D0-93-D1-80-D0-B8-D0-B1-D0-BD-D0-B0-300x200.png",
                    Weight = 530,
                    Ingredients = "Шампіньйони свіжі, моцарела, шампіньйони консервовані, соус пелаті",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Шинок",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/407-D0-971-20-D1-88-D0-B8-D0-BD-D0-BA-D0-BE-D1-8E-300x200.png",
                    Weight = 500,
                    Ingredients = "Шинка, шампіньйони, моцарела, соус пелаті",
                    Price = 110,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Вегетеріанська",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/410-1-D0-92-D0-B5-D0-B3-D0-B0-D1-82-D0-B8-D1-80-D1-96-D0-B0-D0-BD-D1-81-D1-8C-D0-BA-D0-B0-300x200.png",
                    Weight = 530,
                    Ingredients = "Моцарела, помідор, перець болгарський, шампіньйони, маслини, цибуля кримська, соус пелаті",
                    Price = 88,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Міт Мікс",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/406-1-D0-9C-D1-8F-D1-81-D0-BD-D0-B0-20-D0-A4-D0-B0-D0-BD-D1-82-D0-B0-D0-B7-D1-96-D1-8F-300x200.png",
                    Weight = 580,
                    Ingredients = "Салямі, мисливські ковбаски, бекон, посідор, цибуля порей, моцарела, соус пелаті",
                    Price = 142,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Діабло",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/418-1-D0-93-D0-BE-D1-81-D1-82-D1-80-D0-B0-300x200.jpg",
                    Weight = 510,
                    Ingredients = "Шинка, салямі, гострий перець, моцарела",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Салямі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/419-1-D0-A1-D0-B0-D0-BB-D1-8F-D0-BC-D1-96-300x200.jpg",
                    Weight = 510,
                    Ingredients = "Салямі, моцарела, помідор, соус пелаті",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Цезар",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/417-1-D0-A6-D0-B5-D0-B7-D0-B0-D1-80-300x200.jpg",
                    Weight = 550,
                    Ingredients = "Курка, моцарила, помідор, айсберг, соус цезар, соус пелаті",
                    Price = 135,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Папероні",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/416-1-D0-9F-D0-B0-D0-BF-D0-B5-D1-80-D0-BE-D0-BD-D1-96-300x200.jpg",
                    Weight = 530,
                    Ingredients = "Салямі, папероні, моцарела, помідор, болгарський перець, соус пелаті",
                    Price = 130,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "З лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/413-1-D0-A4-D1-96-D0-BB-D0-B0-300x200.jpg",
                    Weight = 510,
                    Ingredients = "Моцарела, філадельфія, лосось, соус пелаті",
                    Price = 165,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Мексиканська",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/411-1-D0-9C-D0-B5-D0-BA-D1-81-D0-B8-D0-BA-D0-B0-D0-BD-D1-81-D1-8C-D0-BA-D0-B0-300x200.png",
                    Weight = 530,
                    Ingredients = "Моцарела, прошуто, помідор, гострий перець, цибуля кримська, петрушка, соус пелаті",
                    Price = 145,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Реджина",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/414-1-D0-A7-D1-96-D0-BA-D0-B5-D0-BD-300x200.jpg",
                    Weight = 575,
                    Ingredients = "Курка, бекон, шампіньйони, помідор, цибуля кримська, моцарела, соус пелаті",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Артишок",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/408-1-D0-90-D1-80-D1-82-D0-B8-D1-88-D0-BE-D0-BA-300x200.png",
                    Weight = 530,
                    Ingredients = "Курка, артишоком, моцарела, фета, соус пелаті",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Три м'яса",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/409-1-D0-9F-D1-96-D1-86-D0-B0-203-20-D0-9C-D1-8F-D1-81-D0-B0-300x200.png",
                    Weight = 615,
                    Ingredients = "Прошуто, шинка, курка, помідор, шампіньйони, цибуля кримська, моцарела, соус пелаті",
                    Price = 145, 
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Маргарита",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/405-1-D0-9C-D0-B0-D1-80-D0-B3-D0-B0-D1-80-D0-B8-D1-82-D0-B0-300x200.png",
                    Weight = 450,
                    Ingredients = "Моцарела, соус пелаті",
                    Price = 79,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Квадро Формаджі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/404-1-D0-9A-D0-B2-D0-B0-D0-B4-D1-80-D0-BE-20-D0-A4-D0-BE-D1-80-D0-BC-D0-B0-D0-B4-D0-B6-D0-BE-300x200.png",
                    Weight = 495,
                    Ingredients = "Пармезан, дор блю, моцарела, фета",
                    Price = 149,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Капрічоза",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/403-1-D0-9A-D0-B0-D0-BF-D1-80-D1-96-D1-87-D1-96-D0-BE-D0-B7-D0-B0-300x200.png",
                    Weight = 590,
                    Ingredients = "Шинка, артишоки, шампіньйони, помідор, моцарела, маслини",
                    Price = 135,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Гавайська",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/402-1-20-D0-93-D0-B0-D0-B2-D0-B0-D0-B9-D1-81-D1-8C-D0-BA-D0-B0-300x200.png",
                    Weight = 500,
                    Ingredients = "Ананас, моцарела, шинка, орегано",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 7
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис з морепродуктами",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-813-Рис-з-морепродуктами-300x200.png",
                    Weight = 270,
                    Ingredients = "Рис варений, Морський коктейль, Болгарський перець, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, соус Пад Тай",
                    Price = 99,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис з морепродуктами",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-812-Рис-з-лососем-300x200.png",
                    Weight = 270,
                    Ingredients = "Рис варений, Лосось, Болгарський перець, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, соус Пад Тай",
                    Price = 129,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис з мідіями",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-811-Рис-з-мідіями-300x200.png",
                    Weight = 270,
                    Ingredients = "Рис варений, М’ясо мідії, Болгарський перець, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, соус Пад Тай",
                    Price = 79,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис зі свининою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-810-Рис-зі-свининою-300x200.png",
                    Weight = 270,
                    Ingredients = "Рис варений, Полядвиця свинна, Болгарський перець, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, Кунжут білий, соус Пад Тай",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис з куркою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-809-Рис-з-куркою-300x200.png",
                    Weight = 270,
                    Ingredients = "Рис варений, Філе куряче, Болгарський перець, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, соус Пад Тай",
                    Price = 67,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис з овочами",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-808-Рис-з-овочами-300x200.png",
                    Weight = 220,
                    Ingredients = "Рис варений, Перець болгарский, Цибуля ріпчаста, Соєвий соус, Часник, 7 спецій, соус Пад Тай",
                    Price = 55,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис Смажений",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-807-Рис-Смажений-300x200.png",
                    Weight = 220,
                    Ingredients = "Рис, Часник, Соєвий соус",
                    Price = 45,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рис паровий",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-806-Рис-паровий-300x200.png",
                    Weight = 200,
                    Ingredients = "Рис варений, Цибуля зелена",
                    Price = 35,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Соба з овочами",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-805-Соба-з-овочами-300x200.png",
                    Weight = 300,
                    Ingredients = "Соба варена, Перець болгарський,Цибуля ріпчаста, Помідор, 7 спецій, Соєвий соус, соус Пад Тай",
                    Price = 69,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Удон з лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-804-Удон-з-лососем-300x200.png",
                    Weight = 300,
                    Ingredients = "Удон Варений, Лосось, Перець болгарський, 7 спецій, Цибуля ріпчата, Соєвий соус, соус Пад Тай",
                    Price = 129,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Удон з кальмаром",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-803-Удон-з-кальмаром-300x200.png",
                    Weight = 300,
                    Ingredients = "Удон Варений, Кальмар трубчастий, Перець болгарський, 7 Спецій, Цибуля ріпчаста, Соєвий соус, соус Пад Тай",
                    Price = 110,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Удон зі свинею",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-802-Удон-зі-свиноною-300x200.png",
                    Weight = 300,
                    Ingredients = "Удон варений, Полядвиця свинна, Перець болгарський, 7 спецій, Цибуля ріпчаста, Соєвий соус, соус Пад Тай",
                    Price = 105,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Удон Торі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-801-Удон-Торі-300x200.png",
                    Weight = 300,
                    Ingredients = "Удон варений, Філе куряче, Перець болгарський, 7 спецій, Цибуля ріпчаста, соєвий соус, соус Пад Тай",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 8
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Місо з лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-714-Місо-з-лососем-300x200.png",
                    Weight = 270,
                    Ingredients = "Соєвий соус, Хондаші, Шиитаке, Вакаме, Місо паста світла, Місо паста темна, Цибуля зелена, Лосось, Сир тофу",
                    Price = 120,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Місо з креветками",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-713-Місо-з-креветками-300x200.png",
                    Weight = 270,
                    Ingredients = "Соєвий соус, Хондаші, Шиитакі, Місо паста світла, Місо паста темна, Водорості вакаме, Тофу, Креветки, Цибуля зелена",
                    Price = 125,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Місо з вугрем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-712-Місо-з-вугрем-300x200.png",
                    Weight = 270,
                    Ingredients = "Місо паста світла, Місо паста темна, Хондаші, Соєвий, Шиитаке гриб, Вакаме, Тофу, Цибуля зелена, Вугор копчений",
                    Price = 119,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Місо Суфідо",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-711-Місо-сіфудо-300x200.png",
                    Weight = 300,
                    Ingredients = "Соєвий соус, Місо паста світла, Місо паста темна, Хондаші, Вакаме, Тофу, Помідор, Морський коктейль, Шиитаке",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Місо",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-710-Місо-300x200.png",
                    Weight = 300,
                    Ingredients = "Соєвий соус, Місо паста світла, Місо паста темна, Тофу, Водорості вакаме, Зелена цибуля",
                    Price = 80,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Клер суп",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-709-Клер-суп-300x200.png",
                    Weight = 250,
                    Ingredients = "Водорості Вакаме, Цибуля зелена, Тофу, Хундаші, Соєвий соус",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Том Ям Торі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-708-Том-Ям-Торі-300x200.png",
                    Weight = 270,
                    Ingredients = "Кокосове молоко, Куряче філе, Соєвий соус, Шампіньйони, Помідори чері, Тайська паста, Рибний соус, Лимонна трава, Листя кафіра, 7 спецій, Соус ширачі, Лимонний Сік",
                    Price = 109,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Том Кха Торі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-707-Том-Кха-Торі-300x200.png",
                    Weight = 270,
                    Ingredients = "Кокосове молоко, Помідор, Куряче філе, Соєвий соус, Шампільйони, Рибний соус, Лимонна трава, Листя кафіра, Лимонний сік",
                    Price = 99,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Том Ям Ебі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-706-Том-Ям-Ебі-300x200.png",
                    Weight = 300,
                    Ingredients = "Кокосове молоко, Креветки тигрові, Кальмар трубчастий, Соєвий соус, Шампільйони, Рибний соус, Лимонна трава, Листя кафіра, Тайська паста, Соус ширачі, Лимонний сік, 7 спецій",
                    Price = 165,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Том Кха Ебі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-705-Том-Кха-Ебі-300x200.png",
                    Weight = 270,
                    Ingredients = "Кокосове молоко, Креветки, Соєвий соус, Шампіньйони, Рибний соус, Лимонна трава, Лист Кафіра, Лимонний сік",
                    Price = 137,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рамен зі свининою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-702-Рамен-зі-свининою-300x200.png",
                    Weight = 270,
                    Ingredients = "Полядвиця Варена, Удон варений ,Соєвий соус, 7 спецій, Яйце куряче, Цибуля зелена, соус Пад Тай",
                    Price = 75,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Рамен",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/10/001-701-Рамен.jpeg-300x200.png",
                    Weight = 300,
                    Ingredients = "Куряче філе, Удон варений, Соєвий соус, 7 спецій, Яйце куряче, Цибуля зелена, соус Пад Тай",
                    Price = 69,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 9
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Марсель",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/608-20-D0-9C-D0-B0-D1-80-D1-81-D0-B5-D0-BB-D1-8C1-300x200.png",
                    Weight = 230,
                    Ingredients = "Лосось смажений, яйце куряче, айсберг, помідор, кукурудза, оливкова олія, діжонська гірчиця",
                    Price = 115,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Цезар з тигровими криветками",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/607-20-D0-A6-D0-B5-D0-B7-D0-B0-D1-80-20-D0-B7-20-D0-9A-D1-80-D0-B5-D0-B2-D0-B5-D1-82-D0-BA-D0-B0-D0-BC-D0-B81-300x200.png",
                    Weight = 200,
                    Ingredients = "Тигрові креветки, пармезан, помідор чері, айсберг, сухарики, соус цезар",
                    Price = 86,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Цезар з копченим лососем",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/salat13-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Копчений лосось, пармезан, помідор чері, айсберг, сухарики, соус цезар",
                    Price = 108,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Цезар з куркою",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/605-cesar1-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Запечена куряча грудинка, пармезан, помідор чері, айсберг, сухарики, соус цезар",
                    Price = 79,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Грецький",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/grechkuy-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Огірок, помідор, перець болгарський, айсберг, цибуля кримська, оливки, маслини, сир фета",
                    Price = 59,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Салат з криветками",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/603-20-D0-A1-D0-B0-D0-BB-D0-B0-D1-82-20-D0-B7-20-D0-BA-D1-80-D0-B5-D0-B2-D0-B5-D1-82-D0-BA-D0-B0-D0-BC-D0-B81-300x200.png",
                    Weight = 200,
                    Ingredients = "Креветка, авокадо, сухарики, масаго оранжева, спайсі соус",
                    Price = 128,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Чука",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/greckuy-300x200.jpg",
                    Weight = 200,
                    Ingredients = "Чука заправлена горіховим соусом",
                    Price = 65,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Ето",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/602-1-300x200.png",
                    Weight = 200,
                    Ingredients = "Запечена курка, суші рис, яйце куряче, авокадо, масаго оранжева, спайсі соус, тофу",
                    Price = 95,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 10
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH морс із журавлини",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2019/01/cranberry_juice-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH томатний",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/08/sok-rich-tomatnyj-new-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Fanta",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/D0-A4-D0-B0-D0-BD-D1-82-D0-B0_PNG-300x200.jpg",
                    Weight = 500,
                    Ingredients = "",
                    Price = 24,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Sprite",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/D0-A1-D0-BF-D1-80-D0-B0-D0-B9-D1-82_PNG-300x200.jpg",
                    Weight = 500,
                    Ingredients = "",
                    Price = 24,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Coca-Cola",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/07/D0-9A-D0-BE-D0-BA-D0-B0-D0-BA-D0-BE-D0-BB-D0-B0_PNG-300x200.jpg",
                    Weight = 500,
                    Ingredients = "",
                    Price = 24,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH Банан-полуниця",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/banan-apelsun-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Nestea",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/nestea-300x200.jpg",
                    Weight = 500,
                    Ingredients = "Холодний чай Nestea – негазований безалкогольний напій",
                    Price = 25,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "bonaqua сильногазована",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/bonaqa-gaz-300x200.jpg",
                    Weight = 500,
                    Ingredients = "Вода BONAQUA походить із глибин Землі. Bона видобувається із Сеноманського та Юрського водоносних горизонтів глибиною 220 и 380 метрів відповідно.",
                    Price = 20,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "bonaqua негазована",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/bnakqa-negaz-300x200.jpg",
                    Weight = 500,
                    Ingredients = "Походить із глибин Землі. Bона видобувається із Сеноманського та Юрського водоносних горизонтів глибиною 220 и 380 метрів відповідно.",
                    Price = 20,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "burn 0.25",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/burn-300x200.jpg",
                    Weight = 0,
                    Ingredients = "Безалкогольний енергетичний напій 18+",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH вишневий",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/vushnya-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH мультивітамін",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/rich-f-300x200.png",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH апельсиновий",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/rich-apelshun-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "RICH яблучний",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/jabluko-300x200.jpg",
                    Weight = 1000,
                    Ingredients = "",
                    Price = 38,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 11
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Соус Унагі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/unagi.jpg",
                    Weight = 50,
                    Ingredients = "Солодкий ароматний соус",
                    Price = 20,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Горіховий соус кешю",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/gorihovy.jpg",
                    Weight = 50,
                    Ingredients = "Горіховий соус – це дуже ніжна паста кремової консистенції зі смаком кунжуту надає стравам надзвичайний аромат і унікальний смак.",
                    Price = 30,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Соус Спайсі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/spaysy.jpg",
                    Weight = 50,
                    Ingredients = "Гострий",
                    Price = 30,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Соєвий соус Kikkoman",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/kikoman.jpg",
                    Weight = 15,
                    Ingredients = "",
                    Price = 120,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Васабі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/vasabi-1.jpg",
                    Weight = 20,
                    Ingredients = "Wasabi",
                    Price = 5,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Імбир",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/Imbir-280x190.jpg",
                    Weight = 40,
                    Ingredients = "Маринований",
                    Price = 7,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                product = new Product
                {
                    Name = "Соус Кімчі",
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/kimchi.jpg",
                    Weight = 50,
                    Ingredients = "Гострий, пекучо-пряний на смак",
                    Price = 25,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 12
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
