using System;
using System.Threading;

namespace multiThread
{
    class PersonalThread
    {
        public int sayac;
        public Thread myThread;
        //constructor
        public PersonalThread(string name)
        {
            sayac = 0;
            myThread = new Thread(new ThreadStart(this.run));
            myThread.Name = name;
            myThread.Start();
        }

        public void run()
        {
            Console.WriteLine(myThread.Name + "başladı");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("sayac:" + sayac);
                sayac++;
            } while (sayac < 10);
            Console.WriteLine(myThread.Name + " bitti");
        }
    }
}