/*Дано рядок, що є параграфом в тексті. 
 * Текст необхідно відформатувати так, 
 * щоб довжина кожного рядка не перевищувала числа m, 
 * слова при цьому не розривати. 
 * На вхід програмі спочатку подається число m (0 < m ≤ 255). 
 * У наступному рядку знаходиться вхідний текст. 
 * Довжина слів в ньому не перевищує m, слова розділені рівно 
 * одним пропуском. Виведіть розбиття цього тексту на рядки довжиною 
 * не більше ніж m символів (слово переноситься на наступний рядок
 * тільки якщо в поточному рядку його розмістити вже неможливо). 
 * Новий рядок не повинен починатися з пропуску.

Вхідні дані:

10
The Wonderful Wizard of Oz
Вихідні дані:
int[] num = new int[] {3, 9, 6, 2, 2, 1, 5, 7,1};

The
Wonderful
Wizard of
Oz*/namespace _04._02._2025___385
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter, please the number m (0 < m ≤ 255) ");
            string enters1 = Console.ReadLine();
            int m = int.Parse(enters1);
            Console.WriteLine("Enter, please the sentence");
            string enters2 = Console.ReadLine();
            int calc = 0;
            string result = "";
            string result2 = "";
            string mid = "";

            
            for (int i = 0; i < enters2.Length; i++)
            {

                if ((enters2[i] == 32 ) && (mid.Length + result.Length) <= m)
                {
                    mid = result;
                    result = enters2.Substring(0, i);
                    result2 = enters2.Substring(i + 1);
                    enters2 = result2;

                    Console.WriteLine(result);
                     result = mid + result;

                }
            }
        }
    }
}
