using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        //работа с бд

        public string ShopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }//список отображаемых элементов в карзине

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //создали новую сессию
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); // проверка: есть ли сессия

            session.SetString("CartId", shopCartId); // устанавливаем ее

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        // позволяем добавлять товары в карзину
        public void AddToCart(Car car)
        {
           
            appDBContent.ShopCarItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            appDBContent.SaveChanges();
        }

        //отображение всех товаров в карзине
        public List<ShopCartItem> getShopItems()
        {
             return appDBContent.ShopCarItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList(); 
            // выбираем те элементы, id карзины которых установлено в сессии и получаем их
        }
             
    }
}
