using System.Diagnostics;
using System;

public class Program {
    public static void Main()
    {
        Console.WriteLine("Hello World");
        
        var list = new WTFList<string>();
        
        int count = 1000;
        
        var valuIdentity = new WTFIdentifier[count];
        
        for(int i = 0; i < count; ++i)
        {
            valuIdentity[i] = list.Add(i * 2, "");
        }
        
        var keys = list.GetAllKeys();
        
        for(int i = 0; i < count; ++i)
        {
            Console.Write(keys[i]);
            Console.Write(',');
        }
        
        var identity = valuIdentity[100];

        while (true)
        {
            Stopwatch lol = Stopwatch.StartNew();
        
            list.GetValuesOnKey(identity.Key);
        
            long time = lol.ElapsedTicks;
        
            lol.Stop();
        
            Console.WriteLine();
        
            Console.Write((((double)time / Stopwatch.Frequency) * 1000));
            Console.Write("MS");

            if(Console.ReadKey().Key == ConsoleKey.Enter) break;
        }
    }
}