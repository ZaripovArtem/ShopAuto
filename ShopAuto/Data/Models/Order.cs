using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Models
{
    public class Order
    {

        [BindNever]
        public int id { get; set; }
        [Display(Name ="Введите Имя")]
        public string name { get; set; }
        [Display(Name = "Введите Фамилию")]
        public string surname { get; set; }
        [Display(Name = "Введите Адрес")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [Display(Name ="Выберите интересующий автомобиль")]
        public string markAndModel { get; set; }
        [Display(Name ="Выберите цвет")]
        public string color { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
