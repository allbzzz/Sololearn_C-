/* Ключевое слово this 
Вам дана программа, которая принимает 2 числа в качестве ввода и должна вычислять и выводить их среднее значение. Но что-то не так.
Завершите класс Avg, создав конструктор, в котором 2 параметра будут присвоены членам класса.

Пример ввода
5.0
4.0

Пример вывода
4.5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;
        public Avg(double num1, double num2)
        {     
            this.num1 = num1;
            this.num2 = num2;
        }
        //create the constructor
        

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
}