using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseEventAndAsync.Enums;

namespace UseEventAndAsync.Models
{
    internal class MessageBox
    {
        public delegate void StateWindowHandler(string stateWindow);

        public event StateWindowHandler StateWindow;
        public async void OpenAsync()
        {
            Random random = new Random();
            string stateWindow = ((EnumStatus)random.Next(0, 2)).ToString();

            Console.WriteLine("The window is Open!");

            Task.Delay(3000);

            Console.WriteLine("The window is closed by the user!");

            StateWindow += StateWindowMethod;
            StateWindow(stateWindow);
        }

        private void StateWindowMethod(string stateWindow)
        {
            if (stateWindow.Equals("Ok"))
            {
                Console.WriteLine("Ok - операція була підтверджена");
            }
            else
            {
                Console.WriteLine("Cancel - операція була відхилена!");
            }
        }
    }
}
