using Microsoft.AspNetCore.Mvc;
using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using ShopAuto.Data.Repository;
using ShopAuto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        //конструктор
        public ShopCartController (IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        //вызов html шаблон и отображение карзины
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        //добавление товара в карзину и переадрессация
        public RedirectToActionResult addToCard(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index"); // переадрессация на Index
        }

    }
}
