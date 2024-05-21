/* Танцы 
На соревнованиях по бальным танцам каждого танцора из пары оценивают отдельно, а затем их очки суммируются, чтобы получить общий балл пары.
Данная программа принимает на вход имена и очки каждого танцора и создает объекты DancerPoints для каждого танцора, 
используя взятые имя и значения баллов в качестве параметров для конструкторов.

Дополните данный класс, используя перегрузку оператора + для возврата нового объекта, 
где имена танцоров находятся в одной строке (см. пример вывода), а оценка равна сумме их очков.

Объявление этого объекта и вывод его очков уже написаны в Main().

Пример ввода
Dave
8

Jessica
7

Пример вывода
Dave & Jessica
15
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator +(DancerPoints dancer1, DancerPoints dancer2)
        {
            return new DancerPoints(dancer1.name + " & " + dancer2.name, dancer1.points + dancer2.points);
        }
    }
}