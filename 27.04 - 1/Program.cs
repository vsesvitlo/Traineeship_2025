/*Завдання 1: Автоматичні властивості
Створи клас Book з автоматичними властивостями:
Title (рядок)
Author (рядок)
Pages (ціле число)
Створи об'єкт і виведи інформацію про книгу.*/

namespace _27._04___1
{
    public class Book
    {
       public string title;
       public string author;
       public int pages;
       /*public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }*/
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int Pages
        {
            get
            {  
                return pages;
            }
            set
            {
                pages = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book FirstExample = new Book();
            FirstExample.title = "Hygge";
            FirstExample.author = "Meik Wiking";
            FirstExample.pages = 285;
            Console.WriteLine("Book is written by: " + FirstExample.Author + ", named " +
                FirstExample.Title + " and has " + FirstExample.Pages + " pages.");
        }
    }
}
