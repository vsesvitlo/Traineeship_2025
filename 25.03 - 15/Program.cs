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
            List<double> list = new List<double> { 10, 3.6, 20 };
            double a = 0;
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                a = list[i];//??
                sum +=Convert.ToInt32(a);
            }
            Console.WriteLine(sum);
        }
    }
}
