using ShopAuto.Data.Interfaces;
using ShopAuto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAuto.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                       mark = "Toyota" ,
                       model = "Chaser VI",
                       shortDesc = "Toyota Chaser – автомобиль С-класса в кузове седан.",
                       longDesc = "Toyota Chaser – автомобиль С-класса в кузове седан и хардтоп, выпускавшийся для внутреннего рынка Японии компанией Toyota с 1977 по 2000 год. Автомобиль был построен на платформе популярного седана Toyota Mark II, Первоначально, в первом поколении, существовала версия в кузове двухдверное купе, однако в дальнейшем от ее выпуска решено было отказаться.",
                       img = "/img/Chaser.jpg",
                       price = 590000,
                       isFavourite = true,
                       available = true,
                       category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        mark = "Toyota ",
                        model = "Crown X (S150)",
                        shortDesc = "Toyota Crown X (S150) 1996 года выпуска в кузове седан",
                        longDesc = "С Х поколения Toyota Crown перестал быть рамным и выпускался в двух кузовах — «седан» и «хардтоп». ",
                        img = "/img/Crown.jpg",
                        price = 200000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategories.Last()
                    },
                    new Car 
                    {
                        mark = "Toyota ",
                        model = "Supra IV (A80)",
                        shortDesc = "Toyota Supra- легендарное японское спортивное купе. ",
                        longDesc = "Toyota Supra- легендарное японское спортивное купе. Последнее поколение с индексом A80 покинуло конвейер в 2002 году и запомнилось своим ярким дизайном, классической компоновкой, необычным салоном, напоминающим кокпит истребителя, а самое главное- мощным мотором, отлично подходящим для дальнейших доработок.",
                        img = "/img/Supra.jpg",
                        price = 1800000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategories.Last()
                    },
                    new Car 
                    {
                        mark = "Nissan ",
                        model = "Silvia ",
                        shortDesc = "Спортивное купе, выпускавшееся японским автопроизводителем Nissan с 1965 по 2002 годы. ",
                        longDesc = "спортивное купе, выпускавшееся японским автопроизводителем Nissan с 1965 по 2002 годы. Купе строилось на платформе Nissan S. Хотя и последние модели разделяли это шасси с другими автомобилями Nissan (в первую очередь европейская 200SX и североамериканская 240SX в поколениях S13 и S14, и модель 180SX на японском рынке), название Silvia на эти автомобили совместно с кодами шасси не переходило",
                        img = "/img/Silvia.jpg",
                        price = 720000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategories.Last()
                    },
                    new Car 
                    {
                        mark = "Nissan ",
                        model = "SKYLINE GT-R BCNR33 ",
                        shortDesc = "Skyline девятого поколения (R33) был выпущен в августе 1993 года",
                        longDesc = "Skyline девятого поколения (R33) был выпущен в августе 1993 года, хотя запуск GT-R был несколько отложен: после его показа осенью 1993 года на 30-м Токийском автосалоне он был, наконец, запущен в январе 1995 года. Этот конкретный автомобиль является прототипом, представленным на Токийском автосалоне; дизайн передней части и дорожного колеса отличается от серийной модели.",
                        img = "/img/Skyline.jpg",
                        price = 3400000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategories.Last()
                    },
                    new Car 
                    {
                        mark = "Mazda ",
                        model = " RX-7",
                        shortDesc = " Спортивный автомобиль, выпускавшийся японским автопроизводителем Mazda с 1978 по 2002 год.",
                        longDesc = " Спортивный автомобиль, выпускавшийся японским автопроизводителем Mazda с 1978 по 2002 год. Оригинальная RX-7 оснащалась двухсекционным роторно-поршневым двигателем и имела переднюю среднемоторную, заднеприводную компоновку. RX-7 пришла на смену RX-3 (обе в Японии продавались под маркой Savanna), вытеснила все остальные роторные автомобили Mazda за исключением Cosmo.",
                        img = "/img/RX-7.jpg",
                        price = 1250000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategories.Last()
                    },


                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getobjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
