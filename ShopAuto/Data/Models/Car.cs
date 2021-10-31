using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Models
{
    public class Car
    {
        public int id { set; get; } // id
        public string model { set; get; } // модель
        public string mark { set; get; }  // марка
        public uint price { set; get; } // цена
        public string img { set; get; } // URL адресс картинки
        public string longDesc { set; get; } // длинное описание
        public string shortDesc { set; get; } // небольшое описание
        public bool isFavourite { set; get; } // отображение на главной страничке
        public bool available { set; get; } // количество
        public int categoryID { set; get; } 
        public virtual Category category { set; get; }
    }
}
