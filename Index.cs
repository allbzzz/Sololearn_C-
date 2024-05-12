/* Индексаторы 
Музыкальное приложение, которым вы пользуетесь, позволяет вам выбрать 5 музыкальных жанров для отслеживания.

Программа, которую вам дана, принимает 5 музыкальных жанров в качестве входных данных и сохраняет их в объекте MusicGenres в виде массива.

Исправьте программу, объявив индексатор внутри класса MusicGenres, чтобы заданные выводы работали правильно.

Пример ввода
Blues
Rock
Hip Hop
Country
Soul

Пример вывода
Following: Blues
Following: Rock
Following: Hip Hop
Following: Country
Following: Soul
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
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }
        }
    }
    class MusicGenres
    {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int index] {
    get {
      return genres[index];
    }
    set {
      genres[index] = value;
    }
    }  
    }
}