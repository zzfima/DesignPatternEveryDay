using static Singletone.Models.Singleton;

DerivedSingletone fromTeachaer = new DerivedSingletone();
PrintDetails("From Teacher");

DerivedSingletone fromStudent = new DerivedSingletone();
PrintDetails("From Student");

Console.ReadLine();