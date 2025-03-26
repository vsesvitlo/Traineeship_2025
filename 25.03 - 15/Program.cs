/*
15. Створи список рядків, які містять числа 
(наприклад, "10", "5.7", "20"). Перетвори їх у double, 
порахуй суму всіх елементів і виведи результат.*/
namespace _25._03___15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "10", "5.7", "20" };
            double a = 0;
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                a = Convert.ToDouble(list[i]);
                sum +=Convert.ToInt32(a);
            }
            Console.WriteLine(sum);
        }
    }
}
