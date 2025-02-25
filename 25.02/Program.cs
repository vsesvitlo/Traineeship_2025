

namespace ConsoleApp1
{
    internal class Prog
    {
        delegate int TwoParams(int x, int y);
        delegate int ThreeMult(int a, int b, int c);
        delegate int Calc(string calcLong);
        delegate int CalcDate(DateTime dataTime);

        public static void Main(string[] args)
        {
            CalcDate newCalc = (DateTime now) =>
            {
                return (int)(DateTime.Now - new DateTime(2000, 1, 1 )).TotalDays;
            };




            Calc text = (string i) =>
            {
               
                return i.Length;
            };

            ThreeMult result = (d, e, f) =>
            {
                return d * e * f;
            };



            TwoParams s = (int a, int b) => 0;
            TwoParams f = (a, b) => {
                a = a + 1;
                b = b + 5;
                return a + b - 6;
            };
            Action b = () => { Console.WriteLine(10); };
            s(1, 2);



            Console.WriteLine("Testcase 1: ");


            string text1 = "hello 2025.1.2 go 5 coins went +3800000000";
            DateOnly[] expectedResult = { new DateOnly(2025, 1, 2) };


            DateOnly[] realResult = DateParser(text1);
            if (expectedResult == realResult)
            {
                Console.Write("Ok");
            }
            else
            {
                Console.Write("False");
            }
        }
        /// <summary>
        /// вибирає із тексту тільки дати
        /// </summary>
        /// <param name="text"></param>
        /// <returns>набір дат із тексту</returns>
        public static DateOnly[] DateParser(string text)
        {
            return null;
        }
        public static int Sum(int a, int b)
        {

            return a + b;
        }

    }
}
