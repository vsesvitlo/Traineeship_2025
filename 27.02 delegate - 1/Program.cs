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
        //delegate int Predicate(int a);
        static List<int> FilterList(List<int> numbers, Predicate <int> func)
        {
            /* for (int i = 0; i < numbers.Count; i++)
             {
                 if (func(numbers[i]) != true)
                 {
                     numbers.RemoveAt(i);
                     i--;
                 }

             }*/
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (func(numbers[i]) != true)
                {
                    numbers.RemoveAt(i);
                    
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 1, 2, 3, 4, 5 });
            FilterList(numbers, x => (x % 2)==0);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
