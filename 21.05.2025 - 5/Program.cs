/*5. Створи інтерфейс IShape з методами GetArea() 
і GetPerimeter(). Реалізуй для Rectangle і Circle.
*/namespace _21._05._2025___5
{
    internal class Program
    {
        interface IShape
        {
            void GetArea(int a, int b);
            void GetPerimeter(int a, int b);
        }
        class Rectangle : IShape
        {

            void IShape.GetArea(int a, int b)
            {
                int area = a * b;
                Console.WriteLine(area);
            }

           public void GetPerimeter(int a, int b)
            {
                int p = (a + b) * 2;
                IShape rectangle = new Rectangle();
                rectangle.GetPerimeter(6, 7);
            }
        }
        class Circle : IShape
        {

            void IShape.GetArea()
            {
                Console.WriteLine("Area");
            }

            public void GetPerimeter()
            {
                IShape circle = new Circle();
                circle.GetPerimeter();
            }
        }
        static void Main(string[] args)
        {
            IShape r = new Rectangle();
            r.GetArea(8, 9);
            r.GetPerimeter( 6, 3);
            IShape c = new Circle();
            c.GetPerimeter();
            c.GetArea();
        }
    }
}
