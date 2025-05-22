/*10. Створи інтерфейс ICalculable з методом Calculate(). 
 * Реалізуй для класів TaxCalculator, DiscountCalculator, LoanCalculator.*/
namespace _21._05._2025___10
{
    internal class Program
    {
        interface ICalculable
        {
            void Calculate();
        }
        class TaxCalculator : ICalculable
        {

            void ICalculable.Calculate()
            {
                Console.WriteLine("Taxes are calculating");
            }

            public void Calculate()
            {
                ICalculable tax = new TaxCalculator();
                tax.Calculate();
            }
        }
        class DiscountCalculator : ICalculable
        {

            void ICalculable.Calculate()
            {
                Console.WriteLine("Discounts are calculating");
            }

            public void Calculate()
            {
                ICalculable discount = new DiscountCalculator();
                discount.Calculate();
            }
        }
        class LoanCalculator : ICalculable
        {

            void ICalculable.Calculate()
            {
                Console.WriteLine("Loans are calculating");
            }

            public void Calculate()
            {
                ICalculable loans = new LoanCalculator();
                loans.Calculate();
            }
        }
        static void Main(string[] args)
        {
            ICalculable console = new TaxCalculator();
            console.Calculate();
            ICalculable discount = new DiscountCalculator();
            discount.Calculate();
            ICalculable loan = new LoanCalculator();
            loan.Calculate();
        }
    }
}
