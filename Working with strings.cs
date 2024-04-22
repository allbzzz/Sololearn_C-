/* Работа со строками 

Вы создаете систему аутентификации.
Пароль не должен содержать ни одного из этих символов:
char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' }; 

Данная программа принимает пароль в качестве ввода.

Задача
Напишите программу, которая выводит "Invalid", если она содержит любые недопустимые символы.
Если требования к паролю выполнены, программа ничего не должна выводить.

Пример ввода
yl1893!dm$

Пример вывода
Invalid

Подсказка
Сообщение должно выводиться только один раз, независимо от того, сколько недопустимых символов содержит пароль.

Используйте цикл for/foreach для итерации по массиву запрещенных символов и проверки условия, затем используйте ключевое слово break для остановки итерации, если условие оценивается как true.
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
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            //your code goes here
            foreach (char c in notAllowedSymbols)
            {
                if (password.Contains(c))
                {
                    Console.Write("Invalid");
                    break;
                }
            }
        }
    }
}