/* Защищенные члены 
Вам дана программа, которая принимает номер счета и его баланс в качестве входных данных.
Она определяет класс Account с 1 членом balance и производит класс User из него с 1 дополнительным членом - номером счета, 
затем создает объект пользователя и пытается сохранить баланс и номер счета в нем, и показывает детали. Но что-то не так.

Исправьте программу так, чтобы она завершила конструктор User(), который должен присваивать параметры соответствующим членам класса User.
Также проверьте модификатор доступа члена balance класса Account.

Входные данные
005615216
1488.36

Выходные данные
Аккаунт N: 005615216
Баланс: 1488.36
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
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account
    {
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }
        
        //complete the constructor
        public User(string accNumber, double balance)
        {
            this.AccNumber = accNumber;
            this.Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}