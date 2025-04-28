/*Завдання 4: Властивість тільки для читання
Створи клас Circle з властивістю Radius і тільки 
для читання властивістю Area,
яка обчислює площу кола.*/
using _27._04___4;

namespace _27._04___4
{
    /*private readonly int MyVal = 5;

    public int MyProp { get { return MyVal; } }
    */
    public class Circle
    {
        private readonly double area;
        public double radius;
        public Circle(double radius)
        {
           // this.area = Math.PI * Math.Pow(radius, 2);
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            set
            {
                Area = Math.PI * Math.Pow(radius, 2);
            }
        }

    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Circle circle = new Circle(3.5);
        Console.WriteLine(circle.Area);
        }
    }


