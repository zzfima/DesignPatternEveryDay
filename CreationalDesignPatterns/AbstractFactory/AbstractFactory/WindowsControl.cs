using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WindowsControl : IControlOS
    {
        public IButton CreateButton()
        {
           return new Windows7Button();
        }
         public ITextBox CreateTextBox()
        {
            return new VistaTextBox();
        }
    }
}
