using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Article myArticle = new Article();
            List<Article> articles = new List<Article>();
            
            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ").ToArray();
                string title = article[0];
                string content = article[1];
                string author = article[2];
                
                myArticle = new Article(title, author, content );
                articles.Add(myArticle);
            }
            
            var sortedList = OrderBy(Console.ReadLine(),articles);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            
        }
        
        public static List<Article> OrderBy(string command, List<Article> articles)
        {
            var sortBycommand = command;
            List<Article> sortedList = new List<Article>();
            
            if (sortBycommand.Equals("title"))
            {
                sortedList = articles.OrderBy(x => x.Title).ToList();
            }
            else if (sortBycommand.Equals("content"))
            {
                sortedList = articles.OrderBy(x => x.Content).ToList();
            }
            else if (sortBycommand.Equals("author"))
            {
                sortedList = articles.OrderBy(x => x.Author).ToList();
            }

            return sortedList;
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        
        public Article() {}
        
        public Article(string title, string author, string content)
        { 
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}