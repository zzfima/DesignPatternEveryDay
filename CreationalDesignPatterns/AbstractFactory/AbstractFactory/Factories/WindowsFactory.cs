using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Controls;

namespace AbstractFactory.Factories
{
    internal class WindowsFactory : IControlFactory
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
