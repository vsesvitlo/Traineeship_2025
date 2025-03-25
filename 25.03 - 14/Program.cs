/*
14. Напиши програму, яка зчитує рядок із числом (double), 
перетворює його в double, потім у int, 
а потім назад у string і виводить всі три значення.*/
namespace _25._03___14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int main = 0;
            string result = "";
            Console.WriteLine("Enter the number, please");
            double item = double.Parse(Console.ReadLine());
            main = (int)item;
            result += Convert.ToString(main); 
            Console.WriteLine(result.GetType());
            Console.WriteLine(main.GetType());
            Console.WriteLine(item.GetType());
        }
    }
}
