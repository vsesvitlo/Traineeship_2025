/*9. Створи інтерфейс IClonable з методом Clone().
Реалізуй його для класу Document, який має заголовок і текст.
*/
namespace _21._05._2025___9
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
