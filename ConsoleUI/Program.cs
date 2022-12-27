using Business.Concrete;
using DataAccess.Concrete;
using Entity.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCardal());

            carManager.Add(new Car() { Id= 3, BrandId=3, ColorId=3, ModelYear= 2020, DailyPrice= 190, Description="Sarı Toyota" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}