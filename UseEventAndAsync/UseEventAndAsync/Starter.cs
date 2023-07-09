using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseEventAndAsync.Models;

namespace UseEventAndAsync
{
    internal class Starter
    {
        public void Run()
        {
            List<MessageBox> tasks = new List<MessageBox>();

            MessageBox messageBox = new MessageBox();
            messageBox.OpenAsync();
        }
    }
}
