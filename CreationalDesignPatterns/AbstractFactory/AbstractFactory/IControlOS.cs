namespace AbstractFactory
{
    internal interface IControlOS
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
