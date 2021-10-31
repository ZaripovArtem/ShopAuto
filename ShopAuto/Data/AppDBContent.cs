using Microsoft.EntityFrameworkCore;
using ShopAuto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent (DbContextOptions<AppDBContent> options) : base(options)
        {

        }


        //Регистрация таблиц
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCarItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }

}



// Регистрация того, какие таблицы будут в БД