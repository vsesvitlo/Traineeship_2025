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
        interface ILogger
        {
            void Log();
        }
        class ConsoleLogger : ILogger
        {

            void ILogger.Log()
            {
                Console.WriteLine("Logging");
            }

            public void Log()
            {
                ILogger log = new ConsoleLogger();
                log.Log();
            }
        }
        class FileLogger : ILogger
        {

            void ILogger.Log()
            {
                Console.WriteLine("logging file");
            }

            public void Log()
            {
                FileLogger file = new FileLogger();
                file.Log();
            }
        }
        static void Main(string[] args)
        {
            ILogger console = new ConsoleLogger();
            console.Log();
            ILogger file = new FileLogger();
            file.Log();
        }
    }
}
