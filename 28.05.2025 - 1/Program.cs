using System.Collections.Generic;

namespace _28._05._2025___1
{
    public class First
    {
        int x;
        int y;
        public First(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    public class Second : First
    {
        public Second(int x, int y) : base(x, y)
        {

        }
    }

    delegate void Example(Second first);
   
internal class Program
    {

        public static void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }
        public static void Min(First second)
        {

        }
        static void Main(string[] args)
        {
            Second ex1 = new Second(6 ,2);
            Example example = Min;
            First exFirst = new First(6, 2);
           
           example.Invoke(exFirst);

        }
    }
}

/*using System.ComponentModel;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Channels;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Prog
    {
        static void Main(string[] args)
        {
            GradFather g1 = new GradFather(100);
            GradFather g2 = new Father(50, 30);
            GradFather g3 = new Son(100, 30, 2);

            //Father f = new GradFather(100);
        }
    }
    class GradFather
    {
        int heigh;
        public GradFather(int heigh)
        {
            this.heigh = heigh;
        }
    }
    class Father : GradFather
    {
        int age;
        public Father(int age, int heighYard): base(heighYard*3)
        {
            this.age = age;
        }
        public Father(): base(100)
        {
            this.age = 50;
        }
    }
    class Son: Father
    {
        int iPod;
        public Son(int heigh, int age, int iPod): base(age, heigh/3)
        {
            this.iPod = iPod;
        }
        public Son(): base()
        {
            this.iPod = 1;
        }
    }

}
*/
