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
       public string Title{ get; set;}
       public string Author{ get; set;}
       public int Pages{get; set;}
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book FirstExample = new Book();
            FirstExample.Title = "Hygge";
            FirstExample.Author = "Meik Wiking";
            FirstExample.Pages = 285;
            Console.WriteLine("Book is written by: " + FirstExample.Author + ", named " +
                FirstExample.Title + " and has " + FirstExample.Pages + " pages.");
        }
    }
}
