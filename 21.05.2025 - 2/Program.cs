/*2. Створи інтерфейс IMovable з методами MoveForward() 
 * і MoveBackward(). Реалізуй його для класів Car і Robot.
3. Створи інтерфейс IPayable з методом Pay(). Реалізуй його в класах Employee і Invoice.
4. Створи інтерфейс ISerializable з методом Serialize() і Deserialize(string data). Реалізуй його в класі User.
5. Створи інтерфейс IShape з методами GetArea() і GetPerimeter(). Реалізуй для Rectangle і Circle.
6. Створи інтерфейс ILogger з методом Log(string message). Реалізуй його для ConsoleLogger і FileLogger.
7. Створи інтерфейс IPlayable з методами Play() і Pause(). Реалізуй його в класах VideoPlayer і MusicPlayer.
8. Створи інтерфейс ICommand з методом Execute(). Реалізуй для команд CopyCommand, PasteCommand, UndoCommand.
9. Створи інтерфейс IClonable з методом Clone(). Реалізуй його для класу Document, який має заголовок і текст.
10. Створи інтерфейс ICalculable з методом Calculate(). Реалізуй для класів TaxCalculator, DiscountCalculator, LoanCalculator.

 */namespace _21._05._2025___2
{
    internal class Program
    {
        interface IMovable
        {
            void MoveForward();
            void MoveBackward();
        }
        class Car: IMovable
        {

            void IMovable.MoveForward()
            {
                Console.WriteLine("I move forward");
            }

            public void MoveForward()
            {
                IMovable forward = new Car();
                forward.MoveForward();
            }
            void IMovable.MoveBackward()
            {
                Console.WriteLine("I move backward");
            }

            public void MoveBackward()
            {
                IMovable backward = new Car();
                backward.MoveForward();
            }
        }

        class Robot : IMovable
        {

            void IMovable.MoveForward()
            {
                Console.WriteLine("Robot move forward");
            }

            public void MoveForward()
            {
                IMovable forward = new Robot();
                forward.MoveForward();
            }
            void IMovable.MoveBackward()
            {
                Console.WriteLine("Robot move backward");
            }

            public void MoveBackward()
            {
                IMovable backward = new Robot();
                backward.MoveForward();
            }
        }
        static void Main(string[] args)
        {
           
            IMovable car1 = new Car();
            car1.MoveBackward();
            car1.MoveForward();
            IMovable robot1 = new Robot();
            robot1.MoveForward(); 
            robot1.MoveBackward();
        }
    }
}

