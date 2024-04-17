/* Нерегулярные массивы 

Отборочные соревнования на Олимпиаду длится 3 дня, и каждый отборочный день выбирается один победитель.
Нерегулярный массив, который вам дан, представляет собой список всех участников, разделенных по количеству дней
(в основном массиве 3 массива, каждый из которых представляет участников, принимавших участие в этот день).

string[][] olympiad = new string[][]
            {
    //day 1 => 5 participants
    new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
    //day 2 => 7 participants
    new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
    //day 3 => 4 participants
    new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana",}
            }; 
Напишите программу, которая принимает числа победителей каждого дня в качестве ввода и выводит их.

Пример ввода
2
3
4

Пример вывода
Bridgette Ramona
Fran Mayur
Kristian Dana

Объяснение
Победителем 1-го дня становится Bridgette Ramona (2-ой участник 1-го дня)
Победителем 2-го дня становится Fran Mayur (3-ий участник 2-го дня)
Победителем 3-го дня становится Kristian Dana (4-ый участник 3-го дня)

Помните, что индексация начинается с 0, так что, если вы хотите выводить Nth участника, вам следует использовать индекс N-1.
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
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());


            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

            };
            //your code goes here
            Console.WriteLine(olympiad[0][day1Winner-1]);
            Console.WriteLine(olympiad[1][day2Winner-1]);
            Console.WriteLine(olympiad[2][day3Winner-1]);
        }
    }
}