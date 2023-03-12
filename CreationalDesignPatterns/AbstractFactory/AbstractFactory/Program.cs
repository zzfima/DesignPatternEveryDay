using AbstractFactory.Factories;

var control = new LinuxFactory();
var button = control.CreateButton();
var txtBox = control.CreateTextBox();
Console.WriteLine($"button event handler: {button.OnClickEventName}, textbox text: {txtBox.Text}");

Console.ReadLine();