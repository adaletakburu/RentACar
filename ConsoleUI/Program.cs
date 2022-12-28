using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();
            //CarDtoTest();
        }

        private static void CarDtoTest()
        {
            CarManager carManager = new CarManager(new EfCardal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -*- {1} *-* {2} -*- {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand() { Id = 6, Name = "Nissan" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} *-* {1}", brand.Id, brand.Name);
            }
            Console.WriteLine("************************");
            brandManager.Update(new Brand() { Id = 6, Name = "Nissan GTR" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} *-* {1}", brand.Id, brand.Name);
            }
            Console.WriteLine("************************");
            brandManager.Delete(new Brand() { Id = 6 });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} *-* {1}", brand.Id, brand.Name);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color() { Id = 5, Name = "Mor" });
            colorManager.Update(new Color() { Id = 5, Name = "Pembe" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("{0} *-* {1}", color.Id, color.Name);
            }
            Console.WriteLine("************************");
            colorManager.Delete(new Color() { Id = 5 });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("{0} *-* {1}", color.Id, color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCardal());

            carManager.Add(new Car() { Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2022, DailyPrice = 250, Description = "Siyah VW" });

            carManager.Update(new Car() { Id = 4, DailyPrice = 200, Description = "Siyah VW Güncelleme" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(new Car() { Id = 4 });
            Console.WriteLine("************************");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}