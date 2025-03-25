/*
 10. Створи програму, яка приймає від користувача числа через пробіл, 
зберігає їх у списку,
а потім конвертує у масив і знаходить суму всіх елементів.*/
namespace _21._03._2025___10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of numbers in the future array, " +
                "please");
            int quantityForArray = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i = 0; i < quantityForArray; i++) {
                Console.WriteLine("Enter the number");
                int itemForArray = int.Parse(Console.ReadLine());
                sum += itemForArray;
            }
            Console.WriteLine(sum);

        }
    }
}
