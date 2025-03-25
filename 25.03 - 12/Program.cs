/*12. Напиши програму, яка зчитує double число від користувача, 
конвертує його у int (відкидаючи дробову частину), 
а потім виводить обидва значення.

*/namespace _25._03___12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double additions = 0;
            int main = 0;
            Console.WriteLine("Enter the number, please");
            double item = double.Parse(Console.ReadLine());
            main = (int)Math.Floor(item);
            double forADD = Convert.ToDouble(main);
            additions = item - forADD;
            Console.WriteLine(additions);
            Console.WriteLine(main);
        }
    }
}
