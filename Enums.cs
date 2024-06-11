/* Enums 

В гоночной видеоигре есть 3 уровня сложности: Easy, Medium и Hard.
Каждому уровню сложности назначается максимальное время для прохождения трассы: чем выше сложность, тем меньше время.
Вам дана программа, которая определяет класс Player и Difficulty enum, и создает 3 объекта Player с разными уровнями 
сложности в качестве параметра для конструктора.

Завершите конструктор Player, который принимает enum в качестве параметра для проверки 
времени для каждого варианта сложности и выводит соответствующее сообщение:
Easy => "You have 3 minutes 45 seconds"
Medium = > "You have 3 minutes 20 seconds"
Hard => "You have 3 minutes"
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    
    /*
    Easy => "You have 3 minutes 45 seconds"
    Medium = > "You have 3 minutes 20 seconds"
    Hard => "You have 3 minutes"
    */

    class Player
    {
        
        public Player(Difficulty x)
        {
            //your code goes here
            string message="You have 3 minutes";
            switch(x){
                case Difficulty.Easy:
                    message+=" 45 seconds";
                    break;
                case Difficulty.Medium:
                    message+=" 20 seconds";
                    break;
                case Difficulty.Hard:
                    message+="";
                    break;
            }
            Console.WriteLine(message);
        }
    }
     enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}