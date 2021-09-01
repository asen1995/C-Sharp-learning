using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace FirstTimeExperience_C_Sharp.multithreading
{
    class MultiThreadingDemo
    {
        public static void startMultiThreadingDemo()
        {
            ThreadStart childref = new ThreadStart(PrintNameThread.CallToChildThread);


            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            childThread.Start();

            //stop the main thread for some time to test abort 
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");
            try
            {
                childThread.Abort();

            }catch (PlatformNotSupportedException e)
            {
                Console.WriteLine("PlatformNotSupportedException occured : " + e );
            }
            Console.ReadKey();

        }
    }
}
