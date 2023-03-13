using SingletoneThreadSafe.Models;

Parallel.Invoke(new Action[]{
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello1")),
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello2")),
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello3")),
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello4")),
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello5")),
    new Action(() =>Singletone.GetInstance.PrintDetails("Hello6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World1")),
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World2")),
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World3")),
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World4")),
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World5")),
    new Action(() =>SingletoneTS.GetInstance.PrintDetails("World6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace1")),
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace2")),
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace3")),
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace4")),
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace5")),
    new Action(() =>SingletoneTSDoubleCheck.GetInstance.PrintDetails("Peace6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land1")),
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land2")),
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land3")),
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land4")),
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land5")),
    new Action(() =>SingletoneEager.GetInstance.PrintDetails("Land6")),});

Console.ReadLine();