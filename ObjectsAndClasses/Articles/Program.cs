using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ").ToArray();
            string title = article[0];
            string content = article[1];
            string author = article[2];
            
            Article myArticle = new Article(title, author, content );

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ").ToArray();

                string command = commands[0];

                if (command.Equals("Edit"))
                {
                    myArticle.Edit(commands[1]);
                }
                else if (command.Equals("ChangeAuthor"))
                {
                    myArticle.ChangeAuthor(commands[1]);
                }
                else if (command.Equals("Rename"))
                {
                    myArticle.Rename(commands[1]);
                }
            }
            
            Console.WriteLine(myArticle);
            
            
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        
        public Article(string title, string author, string content)
        { 
            Title = title;
            Author = author;
            Content = content;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}