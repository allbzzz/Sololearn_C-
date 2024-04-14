/* Использование массивов в циклах 
Вам данная программа принимает 5 чисел в качестве вводных данных и сохраняет их в массиве.
Дополните программу, чтобы она прошла по массиву и вывела сумму четных чисел.

Пример ввода
10
890
15
3699
14

Пример вывода
914

Подсказка
Целое число является четным, если оно делится на два, значит число n является четным, если n%2 равно 0.

Вам нужно объявить отдельную переменную для хранения суммы в ней.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            int sum = 0;
            foreach(int n in numbers)
            {
                if(n%2==0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}