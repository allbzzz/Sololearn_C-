/* Номера карт 
Предоставленная вам программа должна выводить номер счета на банковской карте.
Но что-то не так.
Создайте свойство get для доступа к соответствующему члену класса и также исправьте вывод.

Чтобы выполнить вывод, вы должны передать свойство в метод Console.WriteLine().
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
            Card card1 = new Card();

            //fix the output
            Console.WriteLine(card1.AccountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        public string AccountNum{
        //create a property to get the account
        get {return accountNum;}
        set {accountNum = value;}
        }
    }
}