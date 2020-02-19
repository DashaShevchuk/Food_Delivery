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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
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
                    Image = "https://kvadratsushi.com/rivne/wp-content/uploads/sites/7/2018/06/001-1-s-300x200.jpg",
                    Weight = 210,
                    Ingredients = "Курка копчена, томат, омлет, унагі соус, кунжут, кляр",
                    Price = 117,
                    Count = 1,
                    IsOrdered = false,
                    CategoryId = 3
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
