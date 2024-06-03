/* Абстрактные классы 
Вам дана программа, которая определяет абстрактный класс Figure и производные от него классы Rectangle и Triangle.

Добавьте абстрактный метод Perimeter в класс Figure, затем переопределите его в производных классах, 
чтобы вычислить периметры уже созданных объектов Rectangle и Triangle.

Подсказка
Периметр прямоугольника с шириной w и высотой h => 2*w+2*h.
Периметр треугольника со сторонами s1, s2, s3 => s1+s2+s3.
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
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);

            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());
        }
    }
    abstract class Figure
    {
        //определите абстрактный метод Perimeter без фигуры
        public abstract int Perimeter();
        
    }
    class Rectangle : Figure
    {
        public int width;
        public int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        //определите абстрактный метод Perimeter для прямоугольника
        public override int Perimeter()
        {
            return 2 * width + 2 * height;
        }
        
    }
    class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;
        public Triangle(int s1, int s2, int s3)
        {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        
        //определите абстрактный метод Perimeter для треугольника
        public override int Perimeter()
        {
            return side1 + side2 + side3;
        }
        
    }
}