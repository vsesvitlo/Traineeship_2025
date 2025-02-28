/*Завдання 4: Делегати в подіях
Створіть клас Button, який містить подію OnClick.
Додайте можливість підписуватися на цю подію через
делегат і викликати її при натисканні кнопки
(імітація натискання викликом методу Press).*/

namespace _28._02___1
{
    public delegate void ButtonClickedHandler();

    public event ButtonClickedHandler OnClick;
   
    /* public class Button : EventArgs
     {
         public char ch;
     }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.ButtonClicked += ShowMessage;
          
            button.OnButtonClick();
        }
    }
}
