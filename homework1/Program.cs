using homework1.Models;

namespace homework1;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(6, 3.5, "BMW", "BMW 3 Series", Car.CarColor.Black);
        
        car.GetCarInfo();
        Console.WriteLine(car);
    }
}