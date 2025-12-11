/*
1. Клієнт може себе зареєструвати 
2. Клієнт може набрати в корзину набір товарів
3. Клієнт може їх купити
4. Клієнт бачить історію покупок і в кого він купляв (людину продавця)
 */

using System.Collections.Specialized;
using System.Net;
using System.Xml.Linq;

namespace _04._11._2025___2
{
    public class Client
    {
        public string name;
        public int age;
        public string address;
        public Client(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;

        }
       
    }
    
    public class Shop
    {

    }
    public class Product
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Client first = new Client("A", 33, "ggffi");
            Console.WriteLine("Do you want to registrate? Yes - 1, no - 2");
            int resultRegistration = int.Parse(Console.ReadLine());
            if (resultRegistration == 1)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();
                Client registration = new Client(name, age, address);
                Console.WriteLine($"{registration.name}, {registration.age}, {registration.address}");
            }
            else if(resultRegistration == 2)
            {
                Console.WriteLine("See you later!");
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2");
            }

        }
    }
}
