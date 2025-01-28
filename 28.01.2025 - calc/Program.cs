

internal partial class Program
{
    delegate int Calc (int x, int y);
    static List<int> ts = new List<int>();
    private static void Main(string[] args)
    {
        Calc first = Sum;
       
        first += Min;
        first += Mult;
        first += Min;
        first += Min;
        first += Sum;
        first += Min;
        first += Div;
        first -= Min;
        first -= Min;
        first.Invoke(6, 2);
        foreach (int x in ts)
        {
            Console.WriteLine (x);
        }
        
      

    }
    public static int Sum(int a, int b)
    {
       int result = a + b;
        ts.Add(result);
        return result;
    }
    public static int Mult(int a, int b)
    {
        int result = a * b;
        ts.Add(result);
        return result;
    }
    public static int Min(int a, int b)
    {
        int result = a - b;
        ts.Add(result);
        return result;
    }
    public static int Div(int a, int b)
    {
        int result = a / b;
        ts.Add(result);
        return result;
    }
}
