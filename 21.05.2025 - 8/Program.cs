/*8. Створи інтерфейс ICommand з методом Execute().
Реалізуй для команд CopyCommand, PasteCommand, UndoCommand.
*/
namespace _21._05._2025___8
{
    internal class Program
    {
        interface ICommand
        {
            void Execute();
        }
        class CopyCommand : ICommand
        {

            void ICommand.Execute()
            {
                Console.WriteLine("Copping");
            }

            public void Execute()
            {
                ICommand copy = new CopyCommand();
                copy.Execute();
            }
        }
        class PasteCommand : ICommand
        {

            void ICommand.Execute()
            {
                Console.WriteLine("Pasting");
            }

            public void Execute()
            {
                ICommand paste = new PasteCommand();
                paste.Execute();
            }
        }
        class UndoCommand : ICommand
        {

            void ICommand.Execute()
            {
                Console.WriteLine("Undoing");
            }

            public void Execute()
            {
                ICommand paste = new UndoCommand();
                paste.Execute();
            }
        }
        static void Main(string[] args)
        {
            ICommand copy = new CopyCommand();
            copy.Execute();
            ICommand paste = new PasteCommand();
            paste.Execute();
            ICommand undo = new UndoCommand();
            undo.Execute();
        }
    }
}
