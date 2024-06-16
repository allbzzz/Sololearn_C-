/* Робот-бармен 
У вас есть робот-бармен, и его задача - аккуратно расставить напитки на полках бара. 
Он очень умный и берет столько напитков, сколько необходимо, чтобы равномерно распределить их по полкам, 
но у него все еще есть проблемы с делением.

Программа, установленная в роботе, принимает количество напитков и количество полок на вход.
Дополните программу, чтобы равномерно распределить напитки по полкам: разделив количество напитков на количество полок и вывести результат.
Программа также должна учитывать две возможные проблемы:
1. делитель (количество полок) никогда не должен быть нулем
2. оба ввода должны быть целыми числами.

Для первого исключения программа должна выводить "At least 1 shelf", а для второго - "Please insert an integer".

Пример ввода
6
two

Пример вывода
Please insert an integer
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
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                if (shelves == 0)
                {
                    throw new DivideByZeroException("At least 1 shelf");
                }

                

                int drinksPerShelf = drinks / shelves;
                Console.WriteLine(drinksPerShelf);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please insert an integer");      
            }
        }
    }
}