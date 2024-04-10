/* Массивы 
На игровом автомате установлено 5 игр:
string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" }; 

Напишите программу, которая принимает число N в качестве ввода и выводит соответствующую игру с индексом N из массива.
Если пользователь вводит недопустимое число, которое выходит за пределы диапазона массива, программа должна выводить "Invalid number".

Пример ввода
3

Пример вывода
Puzzle
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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
            int n = int.Parse(Console.ReadLine());
            if (n > 4)
            {
                Console.Write("Invalid number");
            }
            else
            {
                Console.Write(games[n]);
                }
        }
    }
}