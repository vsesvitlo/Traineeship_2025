/*Завдання 2: Використання Func<> і Action<>
Створіть метод ProcessOperation, який приймає делегат Func<int, int, int> 
і два числа.
Використайте його для виконання різних операцій (додавання, множення тощо) 
за допомогою лямбда-виразів.
Микола Оліфірович, [26/02/2025 13:24]
стоврити екземпляр стандартного делегату Funk<>

Микола Оліфірович, [26/02/2025 13:24]
який буде містити в собі функцію яка приймає один int і повертає один int
 */
namespace _26._02___2
{
    internal class Program
    {
        

        static void ProcessOperation(Func <int, int, int, int> func, int d, int e, int f)
        {
            Console.WriteLine(func(d, e, f));
        }


        static void Main(string[] args)
        {
            ProcessOperation((x, y, z) => x + y + z, 5, 3, 8);
            ProcessOperation((x, y, z) => x * y * z, 2, 10, 4);

            Func<int, int> example = (int s) => s + 1;
            Console.WriteLine(example.Invoke(9));
        }
    }
}
