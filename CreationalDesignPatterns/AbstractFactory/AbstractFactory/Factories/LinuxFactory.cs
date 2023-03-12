using AbstractFactory.Controls;

namespace AbstractFactory.Factories
{
    internal class LinuxFactory : IControlFactory
    {
        public IButton CreateButton()
        {
            return new RedHatButton();
        }

        public ITextBox CreateTextBox()
        {
            return new RedHatTextBox();
        }
    }
}
