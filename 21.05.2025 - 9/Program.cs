/*9. Створи інтерфейс IClonable з методом Clone().
Реалізуй його для класу Document, який має заголовок і текст.
*/
namespace _21._05._2025___9
{
    internal class Program
    {
        interface IClonable
        {
            void Clone();
        }
        class Document : IClonable
        {
            string title;
            string text;

            void IClonable.Clone()
            {
                Console.WriteLine( title + text);
            }

            public void Clone()
            {
                IClonable clone = new Document();
                clone.Clone();
            }
        }
       static void Main(string[] args)
        {
            IClonable document = new Document();
           
           //?
            document.Clone();
           
        }
    }
}
