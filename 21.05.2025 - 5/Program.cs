/*5. Створи інтерфейс IShape з методами GetArea() 
і GetPerimeter(). Реалізуй для Rectangle і Circle.
*/namespace _21._05._2025___5
{
    internal class Program
    {
        interface IPayable
        {
            void Pay();
        }
        class Employee : IPayable
        {

            void IPayable.Pay()
            {
                Console.WriteLine("I get payment");
            }

            public void Pay()
            {
                IPayable fromEmployee = new Employee();
                fromEmployee.Pay();
            }
        }
        class Invoice : IPayable
        {

            void IPayable.Pay()
            {
                Console.WriteLine("I am payment");
            }

            public void Pay()
            {
                IPayable toEmployee = new Invoice();
                toEmployee.Pay();
            }
        }
        static void Main(string[] args)
        {
            IPayable employee = new Employee();
            employee.Pay();
            IPayable invoice = new Invoice();
            invoice.Pay();
        }
    }
}
