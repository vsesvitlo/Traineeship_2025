namespace _08._10
{
    public class ForTransform
    {
        public int x = 8;
        public virtual void NewProcess(int x)
        {
            this.x = x;
        }
           
    }
    public class Transform : ForTransform
    {
       public sealed override void NewProcess(int a)
        {
            a = 9;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            ForTransform first = new ForTransform();
            Transform second = new Transform();
            first.NewProcess(11);
            second.NewProcess(99);
            Console.WriteLine(first.x);
            Console.WriteLine(second.x);
        }
}
}
