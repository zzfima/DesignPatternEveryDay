using SingletoneThreadSafe.Models;

Parallel.Invoke(new Action[]{
    new Action(()=>Singletone.PrintDetails("Hello1")),
    new Action(()=>Singletone.PrintDetails("Hello2")),
    new Action(()=>Singletone.PrintDetails("Hello3")),
    new Action(()=>Singletone.PrintDetails("Hello4")),
    new Action(()=>Singletone.PrintDetails("Hello5")),
    new Action(()=>Singletone.PrintDetails("Hello6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(()=>SingletoneTS.PrintDetails("World1")),
    new Action(()=>SingletoneTS.PrintDetails("World2")),
    new Action(()=>SingletoneTS.PrintDetails("World3")),
    new Action(()=>SingletoneTS.PrintDetails("World4")),
    new Action(()=>SingletoneTS.PrintDetails("World5")),
    new Action(()=>SingletoneTS.PrintDetails("World6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace1")),
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace2")),
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace3")),
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace4")),
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace5")),
    new Action(()=>SingletoneTSDoubleCheck.PrintDetails("Peace6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(()=>SingletoneEager.PrintDetails("Land1")),
    new Action(()=>SingletoneEager.PrintDetails("Land2")),
    new Action(()=>SingletoneEager.PrintDetails("Land3")),
    new Action(()=>SingletoneEager.PrintDetails("Land4")),
    new Action(()=>SingletoneEager.PrintDetails("Land5")),
    new Action(()=>SingletoneEager.PrintDetails("Land6")),});

Console.WriteLine("**************************");

Parallel.Invoke(new Action[]{
    new Action(()=>SingletoneLazy.PrintDetails("Air1")),
    new Action(()=>SingletoneLazy.PrintDetails("Air2")),
    new Action(()=>SingletoneLazy.PrintDetails("Air3")),
    new Action(()=>SingletoneLazy.PrintDetails("Air4")),
    new Action(()=>SingletoneLazy.PrintDetails("Air5")),
    new Action(()=>SingletoneLazy.PrintDetails("Air6")),});

Console.ReadLine();
