/*8. Створи інтерфейс ICommand з методом Execute().
Реалізуй для команд CopyCommand, PasteCommand, UndoCommand.
*/
namespace _21._05._2025___8
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
