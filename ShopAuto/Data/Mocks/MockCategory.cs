using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Бензиновые автомобили", desc = "Автомобили с ДВС"}
                };
            }
        }

    }
}
