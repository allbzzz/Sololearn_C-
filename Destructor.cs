/* Деструкторы 
Пять участников прошли в финальный раунд телевизионной викторины, и пришло время объявить победителя и закончить игру.
Программа, которую вы получили, определяет массив финалистов, принимает индекс победителя в качестве ввода и создает объект FinalRound.

Дополните класс FinalRound, написав необходимый код в конструкторе для принятия массива и индекса победителя в качестве параметров и 
вывода соответствующего сообщения для отображения победителя. Затем создайте деструктор, чтобы закончить игру и вывести "Game Over".

Пример ввода
2

Пример вывода
Winner is Leyla Brown
Game Over
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
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            //this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            //complete the constructor
            Console.WriteLine("Winner is " + finalists[winner]);
        }

        ~FinalRound()
        {
            Console.WriteLine("Game Over");
        }
        //create destructor => "Game Over"
    }
}