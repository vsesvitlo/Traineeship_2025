/*5. Створи інтерфейс IShape з методами GetArea() 
і GetPerimeter(). Реалізуй для Rectangle і Circle.
*/namespace _21._05._2025___5
{
    internal class Program
    {
        interface IShape
        {
            public double GetArea();
            double GetPerimeter();
        }
        class Rectangle : IShape
        {
            double a;
            double b;
            public double GetArea()
            {
                double area = a * b;
                Console.WriteLine(area);
                return area;                  
            }

           public double GetPerimeter()
            {
               double area = 2 * (a + b);
               return area;
            }
        }
        class Circle : IShape
        {
            public double radius;

             public double GetArea()
            {
                double circleShape = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine(circleShape);
                return circleShape;
                
            }

            public double GetPerimeter()
            {
                double perimeter = 2 * Math.PI * radius;
                return perimeter;
            }
        }
        static void Main(string[] args)
        {
            IShape r = new Rectangle();
            int a = 8;
            int t = 6;
            r.GetArea();
              //r.GetArea(4, 9); //?
            r.GetPerimeter();
            IShape c = new Circle();
            c.GetPerimeter();
            c.GetArea();
        }
    }
}
