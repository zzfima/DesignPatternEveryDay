using static Singletone.Models.Singleton;

DerivedSingletone fromTeachaer = new DerivedSingletone();
fromTeachaer.PrintDetails("From Teacher");

DerivedSingletone fromStudent = new DerivedSingletone();
fromStudent.PrintDetails("From Student");

Console.ReadLine();