namespace AbstractFactory
{
    internal class LinuxControl : IControlOS
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
