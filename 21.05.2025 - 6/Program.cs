/*6. Створи інтерфейс ILogger з методом Log(string message). 
Реалізуй його для ConsoleLogger і FileLogger.
7. Створи інтерфейс IPlayable з методами Play() і Pause().
Реалізуй його в класах VideoPlayer і MusicPlayer.
8. Створи інтерфейс ICommand з методом Execute().
Реалізуй для команд CopyCommand, PasteCommand, UndoCommand.
9. Створи інтерфейс IClonable з методом Clone().
Реалізуй його для класу Document, який має заголовок і текст.
10. Створи інтерфейс ICalculable з методом Calculate(). 
Реалізуй для класів TaxCalculator, DiscountCalculator, LoanCalculator.
*/namespace _21._05._2025___6
{
    internal class Program
    {
        interface IPayable
        {
            void Pay();
        }
        class Employee : IPayable
        {

            void IPayable.Pay()
            {
                Console.WriteLine("I get payment");
            }

            public void Pay()
            {
                IPayable fromEmployee = new Employee();
                fromEmployee.Pay();
            }
        }
        class Invoice : IPayable
        {

            void IPayable.Pay()
            {
                Console.WriteLine("I am payment");
            }

            public void Pay()
            {
                IPayable toEmployee = new Invoice();
                toEmployee.Pay();
            }
        }
        static void Main(string[] args)
        {
            IPayable employee = new Employee();
            employee.Pay();
            IPayable invoice = new Invoice();
            invoice.Pay();
        }
    }
}
