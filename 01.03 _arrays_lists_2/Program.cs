/*2. Створи список рядків, що містить три довільні слова. 
 * Перетвори цей список у масив,
 * після чого виведи елементи масиву в зворотному порядку.*/
namespace _01._03__arrays_lists_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.AddRange(new string[] { "adfg", "Ryiu;j", "k"});
            words.ToArray();
            for (int i = words.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
