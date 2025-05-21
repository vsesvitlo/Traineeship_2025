/*2. Створи інтерфейс IMovable з методами MoveForward() 
 * і MoveBackward(). Реалізуй його для класів Car і Robot.

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

