/*Завдання 3 B: Зміна списку через делегат
Напишіть метод MapList, який приймає список слів 
та делегат Predicate<string>. Метод має повертати новий список, 
який містить тільки числа кількість букв кожного стрінга.*/

namespace _28._02___delegate___2
{
    //List<int> FilterList(List<int> numbers, Predicate <int> func
    
    internal class Program
    {
        delegate int ToIntTransform(string a);
        static List<int> MapList(List<string> words, ToIntTransform transform)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < words.Count; i++)
            {
                transform(words[i]);
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.AddRange(new string[] { "adfg", "Ryiu;j", "k", "ppp" });
            ToIntTransform
        }
    }
}
