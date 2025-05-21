/*3. Створи інтерфейс IPayable з методом Pay(). 
 * Реалізуй його в класах Employee і Invoice.
*/
namespace _21._05._2025___3
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
