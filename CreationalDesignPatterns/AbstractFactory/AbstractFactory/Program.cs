// See https://aka.ms/new-console-template for more information
using AbstractFactory;

var control = new LinuxControl();
var button = control.CreateButton();
var txtBox = control.CreateTextBox();
Console.WriteLine($"button event handler: {button.OnClickEventName}, textbox text: {txtBox.Text}");

Console.ReadLine();