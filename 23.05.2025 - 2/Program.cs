/*Микола Оліфірович, [23/05/2025 13:02]
Користувач вказує розмір масива,

Микола Оліфірович, [23/05/2025 13:02]
вводить всі числа

Микола Оліфірович, [23/05/2025 13:02]

користувач вводить індекс що ділиться і індекс на що ділиться і поділити

Микола Оліфірович, [23/05/2025 13:03]
Виводиться результат*/
namespace _23._05._2025___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int n = 0;
            int[] ints = new int[size]; 
            for (int i = 0; i < size; i++) {
                Console.WriteLine("Enter the number");
                n = int.Parse(Console.ReadLine());
                ints[i] = n;
            }
            Console.WriteLine("Enter the diveden index");
            int dividen = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor index");
            int divisor = int.Parse(Console.ReadLine());
            try
            {
                int quotient = ints[dividen] / ints[divisor];

                Console.WriteLine($"The result is: {quotient}" );
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Division by zero is forbitten");
            }

        }
    }
}
