/* Обработка исключений 
Туроператор предлагает пакетные туры в Англию, Испанию, Италию, Португалию и Францию.

Вам дана программа, которая определяет массив с этими вариантами и принимает число N в качестве ввода.
Напишите программу, чтобы вывести вариант пакета с индексом N. Если число выходит за пределы диапазона, программа должна выводить "Wrong number". Независимо от результатов выбора, программа должна выводить "Goodbye" в конце.

Пример ввода
2

Пример вывода
Italy
Goodbye
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
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());
            
            //введите код сюда
            try
            {
                Console.WriteLine(tours[choice]);
            }
            catch
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}