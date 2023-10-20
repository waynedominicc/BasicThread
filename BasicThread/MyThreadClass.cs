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
            for (int loopcount = 1; loopcount <= 5; loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopcount);
                Thread.Sleep(1500);
            }
        }
    }
}
