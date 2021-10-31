using Microsoft.AspNetCore.Mvc;
using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            return RedirectToAction("Complete");
        }

        public IActionResult Complete()
        {
            return View();
        }
        public IActionResult About ()
        {
            return View();
        }
    }
}
