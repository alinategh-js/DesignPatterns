using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.GetInstance;
            var s2 = Singleton.GetInstance;
            if (s1 == s2) Console.WriteLine("s1 and s2 are both the same instance of the Singleton class.");

            var x = s1.Add(6, 2);
            Console.WriteLine(x);
        }
    }
}
