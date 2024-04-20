/* Свойства и методы массивов 
 
Написать программу, которая принимает 5 чисел на вход, затем вычисляет и выводит сумму максимального и минимального введенных значений.

Пример ввода
5
6
14
2
1

Пример вывода
15

Объяснение
Минимальное значение - 1, максимальное - 14. Так что 14+1 = 15 должно быть выведено.

Подсказка
Создайте массив, используйте цикл while для сохранения введенных чисел в него, а затем выполните вычисления.

Используйте методы Min и Max для получения минимального и максимального значений.
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
            //your code goes here
            int[] num = new int[5];
            num[0] = int.Parse(Console.ReadLine());
            num[1] = int.Parse(Console.ReadLine());
            num[2] = int.Parse(Console.ReadLine());
            num[3] = int.Parse(Console.ReadLine());
            num[4] = int.Parse(Console.ReadLine());
            
            Console.WriteLine(num.Max() + num.Min());
        
        
        }
    }
}