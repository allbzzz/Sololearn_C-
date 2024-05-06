/* Статические члены  
У компании есть 2 отдела и она растет, поэтому требуются дополнительные отделы.

Данная программа принимает количество отделов, которые нужно открыть, в качестве ввода, 
затем принимает их имена и создает объекты Department, передавая их имена в конструктор.

Дополните класс Department, чтобы он имел 1 статический член depCount с начальным значением 2 для числа отделов и 
конструктор, который будет считать это и выводить соответствующее сообщение (см. пример вывода).

Пример ввода
2
Finance
Marketing

Пример вывода
Отдел открыт: Finance
Отдел открыт: Marketing
Количество отделов: 4

Объяснение
Первый ввод представляет собой количество отделов, которые нужно открыть, затем следуют их имена.
В результате программа выводит соответствующие сообщения (1-й и 2-й выводы) и общее количество отделов: 2 (начальное) + 2 (открыто) = 4.
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
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {
        public static int depCount = 2;
        public string depName;

        //declare static depCount member with value of 2

        //complete the constructor
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            depCount ++;
        }
    }
}