using Microsoft.AspNetCore.Mvc;
using ShopAuto.Data.Interfaces;
using ShopAuto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        //конструктор
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
         
        }

        public ViewResult Index()
        {
            var HomeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(HomeCars);
        }

    }
}
