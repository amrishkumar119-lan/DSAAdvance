using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.designPatterns
{
    // Design Pattern: Singleton Pattern (Creational)
    // Purpose: Ensure a class has only ONE instance, with a global access point.
    // This version is thread-safe using double-checked locking — verify with the
    // two-thread test in Main() that only "Call 1" prints (constructor runs once).
    public class singalTon
    {
        public static int count;
        public int _id { get; set; }
        private static singalTon _instance;
        private static readonly object _lock = new object();
        private singalTon()
        {
            count++;
            Console.WriteLine("Call " + count);
        }


        public static singalTon GetInstance(int id)
        {

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new singalTon();
                        _instance._id = id;
                    }
                }
            }
            return _instance;
        }


    }



    public class program
    {
        public static void Main()
        {
            Thread thread = new Thread(() =>
            {
                var obj1 = singalTon.GetInstance(1);
            });
            Thread thread1 = new Thread(() =>
            {
                var obj2 = singalTon.GetInstance(2);
            });
            thread.Start();
            thread1.Start();

            thread.Join();
            thread1.Join();
            //singalTon obj = singalTon.GetInstance();
            //singalTon obj1 = singalTon.GetInstance();
        }
    }
}
