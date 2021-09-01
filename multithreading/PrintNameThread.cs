using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace FirstTimeExperience_C_Sharp.multithreading
{
    class PrintNameThread
    {

        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");

                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

    }
}
