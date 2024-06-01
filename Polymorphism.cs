/* Полиморфизм 
В пошаговой стратегической игре каждый юнит может атаковать.

Стандартный юнит атакует с помощью меча. Но есть еще два типа юнитов - мушкетеры и маги, которые атакуют своим собственным способом.
Вам дана программа, которая объявляет класс Unit с методом Attack(). Он выводит "Using sword!".

Создайте классы Musketeer и Magician, производные от класса Unit, и переопределите его метод Attack() для вывода соответствующих сообщений при атаке:
Musketeer => "Using musket!"
Magician =>"Using magic!"
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
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    
    /*derive the class from Unit class
    and override Attack() method*/
    class Musketeer: Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }
    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician: Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }
    }
}