/* Structs 
Кубоид - это трехмерная фигура с длиной, шириной и высотой.

Данная программа принимает эти размеры в качестве входных данных, определяет структуру Cuboid и создает ее объект. 
Дополните программу, создав конструктор, который будет принимать длину, ширину и высоту в качестве параметров и присваивать их членам своей структуры. 
Также завершите методы Volume() и Perimeter() внутри структуры, чтобы вычислять и возвращать их, чтобы заданные вызовы методов работали правильно.

Пример Ввода
5
4
5

Пример Вывода
Volume: 100
Perimeter: 56
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
        
        static void Main(string[] args) {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Cuboid cuboid = new Cuboid(length, width, height);
            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
    struct Cuboid {
        public int length;
        public int width;
        public int height;
        public Cuboid(int length, int width, int height) {
           this.length = length;
           this.width = width;
           this.height = height;
        }
        public int Volume() {
            return length*width*height;
        }
       public int Perimeter() {
            return 4*length+4*width+4*height;
       }
   }
}