/*Конструкторы 
Вашему графическому приложению необходимо сообщать о том, что новый проект был успешно создан после нажатия кнопки "Create".

Дополните данной класс, добавив конструктор, который будет выводить сообщение "Project created" после завершения операции.

Вам нужно выполнить вывод внутри конструктора.
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
            Project project = new Project();
        }
    }
    class Project
    {
        //create a constructor to show "Project created"
        public Project()
        {
            Console.WriteLine("Project created");
        }
    }
}