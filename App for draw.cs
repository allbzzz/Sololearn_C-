/* Приложение для рисования 
Вы создаете приложение для рисования и в настоящее время у вас есть только 1 инструмент - карандаш. 
Вы хотите добавить кисть и спрей на панель инструментов для рисования.

Программа, которую вам дали, объявляет интерфейс IDraw с методом StartDraw(), и класс Draw, 
который выполняет рисование карандашом, реализуя интерфейс IDraw. Он выводит "Using pencil".

Дополните указанные классы Brush и Spray, 
- наследуя их от класса Draw
- реализуя метод StartDraw() для каждого инструмента, чтобы выводить
"Using brush" для Brush, или
"Using spray" для Spray.

Объекты Draw и их вызовы методов предоставлены в Main().
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }
    }

    class Spray : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
}