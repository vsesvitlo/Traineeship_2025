/*11. Напиши програму, яка зчитує з консолі ціле число у вигляді рядка,
 * конвертує його у int, множить на 2 і виводить результат.
*/
namespace _25._03___11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int result = 0; 
        Console.WriteLine("Enter the number, please");
        int item = int.Parse(Console.ReadLine());
        result = item*2;
        Console.WriteLine(result);
        }
    }
}
