/*11. Напиши програму, яка зчитує з консолі ціле число у вигляді рядка,
 * конвертує його у int, множить на 2 і виводить результат.

15. Створи список рядків, які містять числа 
(наприклад, "10", "5.7", "20"). Перетвори їх у double, 
порахуй суму всіх елементів і виведи результат.*/
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
