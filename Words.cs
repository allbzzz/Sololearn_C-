/* Слова 
Вам дана программа, которая определяет массив из 10 слов и принимает букву в качестве ввода.

Напишите программу, которая будет итерировать по массиву и выводить слова, содержащие данную букву.
Если такого слова нет, программа должна выводить "No match".

Пример ввода
u

Пример вывода
fun

Вспомните метод Contains().
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}