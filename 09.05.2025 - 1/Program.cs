/*1. Створи інтерфейс IDrawable з методом Draw(). 
 * Реалізуй його в класах Circle, Square і Triangle.
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
