/*1. Створи інтерфейс IDrawable з методом Draw(). 
 * Реалізуй його в класах Circle, Square і Triangle.
2. Створи інтерфейс IMovable з методами MoveForward() і MoveBackward(). Реалізуй його для класів Car і Robot.
3. Створи інтерфейс IPayable з методом Pay(). Реалізуй його в класах Employee і Invoice.
4. Створи інтерфейс ISerializable з методом Serialize() і Deserialize(string data). Реалізуй його в класі User.
5. Створи інтерфейс IShape з методами GetArea() і GetPerimeter(). Реалізуй для Rectangle і Circle.
6. Створи інтерфейс ILogger з методом Log(string message). Реалізуй його для ConsoleLogger і FileLogger.
7. Створи інтерфейс IPlayable з методами Play() і Pause(). Реалізуй його в класах VideoPlayer і MusicPlayer.
8. Створи інтерфейс ICommand з методом Execute(). Реалізуй для команд CopyCommand, PasteCommand, UndoCommand.
9. Створи інтерфейс IClonable з методом Clone(). Реалізуй його для класу Document, який має заголовок і текст.
10. Створи інтерфейс ICalculable з методом Calculate(). Реалізуй для класів TaxCalculator, DiscountCalculator, LoanCalculator.
*/
namespace _09._05._2025___1
{
    internal class Program
    {
        interface IDrawable
        {
            void Draw();
        }
        class Circle: IDrawable
        {
            
            void IDrawable.Draw()
            {
                Console.WriteLine("I draw circle");
            }

            public void Draw()
            {
                IDrawable circle = new Circle();
                circle.Draw();
            }
        }
        class Square : IDrawable
        {

            void IDrawable.Draw()
            {
                Console.WriteLine("I draw square");
            }

           public void Draw()
            {
                IDrawable square = new Square();
               
                square.Draw();
            }
        }
        class Triangle: IDrawable
        {

            void IDrawable.Draw()
            {
                Console.WriteLine("I draw triangle");
            }

           public void Draw()
            {
                IDrawable triangle = new Triangle();
               
                triangle.Draw();
            }
        }
        static void Main(string[] args)
        {
            IDrawable drawable = new Circle();
            drawable.Draw();
            IDrawable t = new Triangle();
            t.Draw();
            IDrawable s = new Square();
            s.Draw();
        }
    }
}
