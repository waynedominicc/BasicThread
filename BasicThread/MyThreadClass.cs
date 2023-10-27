using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1() 
        {
            for (int loopcount = 0; loopcount <= 2; loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopcount);
                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            for (int loopcount = 0; loopcount <6; loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopcount);
                Thread.Sleep(1500);
            }
        }
    }
}
