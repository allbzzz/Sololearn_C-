/* Интерфейсы 
На сайте автосалона вы можете предварительно заказать автомобиль, указав его цвет и комплектацию.
Вам дана программа, которая принимает цвет и тип комплектации в качестве входных данных и передает их в конструктор уже объявленного класса Car.

Реализуйте интерфейсы IColor и IEquipment для класса Car и переопределите их методы GetColor и GetEquipment внутри него. 
Каждый из них должен выводить соответствующее сообщение о цвете/комплектации (см. пример вывода).

Пример ввода
Blue
Standard

Пример вывода
Color: Blue
Equipment: Standard
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }

    // Implement IColor & IEquipment interfaces
    public class Car : IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }

        public void GetColor()
        {
            Console.WriteLine("Color: " + color);
        }

        public void GetEquipment()
        {
            Console.WriteLine("Equipment: " + equipment);
        }
    }
}