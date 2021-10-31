using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            throw new NotImplementedException();
        }

    
        public void CreteOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            //Нужно добавить сохранение в базу иначе выбивает ошибку и не сохраняет
            appDBContent.SaveChanges();
            var items = shopCart.listShopItems;

            foreach (var el in items)
            {

                var orderDeteil = new OrderDetail
                {
                    carID = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                appDBContent.OrderDetail.Add(orderDeteil);
                appDBContent.SaveChanges();

            }

            appDBContent.SaveChanges();
        }
    }
}
