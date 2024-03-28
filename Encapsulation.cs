/*Инкапсуляция 

Мы разрабатываем систему профилей для игроков нашей онлайн игры.
Программа уже принимает количество игр и побед в качестве ввода и создает объект игрока.
Завершите метод GetWinRate() в данном классе Player для расчета и вывода процента побед.

Пример ввода
130
70

Пример вывода
53

Объяснение
Процент побед рассчитывается по этой формуле: победы*100/игры. Так что, в данном случае процент 
побед составляет 70*100/130 = 53 (окончательный результат должен быть целым числом).

Обратите внимание, что вы должны выполнить output выигрышного коэффициента внутри метода.
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
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }
    
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            winrate = (wins * 100) / games;
            Console.WriteLine(winrate);
        }
    }
}