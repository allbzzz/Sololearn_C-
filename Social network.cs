/* Социальная сеть 
Вы создаете приложение для социальной сети и хотите добавить функционал создания постов.
Когда пользователь создает пост, текст "New post" должен автоматически выводиться, чтобы затем пользователь мог добавить текст, который он/она хочет поделиться.
В предоставленной вам программе объявлен класс Post с закрытым полем text , и метод ShowPost() , который выводит содержимое.

Дополните класс:
- конструктором, который выводит "New post" при вызове,
- свойством Text , которое позволит вам получать и устанавливать значение поля text.

После того как вы внесете изменения в программу, чтобы она работала корректно, то в main программа получит текст поста от пользователя, создаст объект поста, присвоит полученное значение полю text и выведет его.

Пример ввода
Hello!

Пример вывода
New post
Hello!

Вспомните ключевое слово value для сеттера.
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;
        
        // Constructor
        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        // Property for member text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}