using AbstractFactory.Controls;

namespace AbstractFactory.Factories
{
    internal interface IControlFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
