using System;
using System.Threading;

namespace multiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalThread thread1 = new PersonalThread("thread1");


            Thread.Sleep(2000);

            thread1.myThread.Suspend();
            Console.WriteLine(thread1.myThread.Name + " durduruldu.");
            Thread.Sleep(1000);
            thread1.myThread.Resume();
            Console.WriteLine(thread1.myThread.Name + " devam ettirildi.");
        }
    }
}
