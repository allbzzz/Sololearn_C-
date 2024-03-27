/*Добро пожаловать!
Определите класс Welcome, который имеет один публичный метод под названием WelcomeMessage, 
и при его вызове должен выводить "Welcome to OOP".

Не забудьте добавить спецификатор доступа - ключевое слово public.
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
            //create a Welcome object with the same name
            Welcome welcome = new Welcome();
            
            welcome.WelcomeMessage();
        }
    }
    
    class Welcome
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to OOP");
        }
        
        
    }
}