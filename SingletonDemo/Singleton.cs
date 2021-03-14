using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static int counter = 0;
        private static readonly object padlock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Singleton has been instantiated {counter} times.");
            // this is to check if we are violating Singleton pattern.
        }
        public static Singleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public decimal Add(decimal a, decimal b) => a + b;
    }
}
