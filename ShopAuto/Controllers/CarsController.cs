using Microsoft.AspNetCore.Mvc;
using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using ShopAuto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat )
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);

            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.category.categoryName.Equals("Бензиновые автомобили")).OrderBy(i => i.id);
                }

                currCategory = _category;

       
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Страница с автомобилями";
            


            return View(carObj);
        }
    }
}
