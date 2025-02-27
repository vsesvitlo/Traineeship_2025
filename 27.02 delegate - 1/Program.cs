/*Завдання 3: Фільтрація списку через делегат
Напишіть метод FilterList, який приймає список чисел та делегат Predicate<int>.
Метод має повертати новий список, який містить тільки ті числа,
для яких делегат повертає true.
Використайте цей метод для фільтрації парних чисел зі списку.*/

using System.Xml.Linq;

namespace _27._02_delegate___1
{
    internal class Program
    {
        delegate int Predicate(int a);
        static void FilterList(List<int> func, Predicate pred)
        {
           
            if (pred == true)
               

            return 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
