/* Многомерные массивы 
Следуйте данным многомерным массивам:
int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

Дополните программу для вывода этого массива в виде таблицы (без разделения):
123
456
789

Используйте вложенные циклы for для итераций по строкам и столбцам.
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
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //your code goes here
            for (int k = 0; k < 3; k++) {
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine(num[k, j]);
                }
                //Console.Write();
            }
        }
    }
}