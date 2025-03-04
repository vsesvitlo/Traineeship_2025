/*9. Напиши програму, яка зчитує рядок від користувача,
 * розбиває його на масив слів (роздільник – пробіл), 
 * а потім зберігає тільки унікальні 
 * слова у список і виводить їх в алфавітному порядку.*/

namespace _02._03__arrays_lists_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter some text");
            string forReading = Console.ReadLine();
            int count = 1;
            string word = "";
            for (int i = 0; i < forReading.Length; i++)
            {
               // Console.WriteLine(forReading[i].GetType());
                if (forReading[i] == 32)
                {
                    count++;
                }
            }
            //Console.WriteLine(count);
            string[] words = new string[count];
            for (int j = 0; j < forReading.Length; j++)
            {
                for(int k = 0; k < count; k++)
                {
                    word = forReading.Substring(0, j);
                    words[k] = word;
                    if (forReading[j] == 96)
                    {
                        word = forReading.Substring(j, j);
                        words[k] = word;  
                    }
                   // word = forReading.Substring(j, forReading.Length - 1);
                    words[k] = word;
                }


            }
            Console.WriteLine(word);
        }
    }
}
