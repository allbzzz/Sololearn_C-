/* Наследование 
Данная программа принимает в качестве входных данных марку и модель автомобиля, и определяет класс Vehicle с свойством model и методом ShowModel().

Дополните класс Car так, чтобы он наследовал класс Vehicle, и добавьте свойство Model и метод ShowModel(), 
чтобы данный метод вызова объекта автомобиля работал корректно (см. пример вывода).

Пример ввода
BMW
5 Series

Пример вывода
Brand: BMW
Model: 5 Series
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }
    }
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    //complete the Car class
    class Car: Vehicle
    {
        public string Model { get; set; }
        public void ShowModel()
        {
            Console.WriteLine("Model: " + Model);
        }       
    }
}