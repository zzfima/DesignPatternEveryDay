using Singletone.Models;

Singleton fromTeachaer = Singleton.GetInstance;
Singleton.PrintDetails("From Teacher");
Singleton fromStudent = Singleton.GetInstance;
Singleton.PrintDetails("From Student");

Console.ReadLine();