using System;
using System.Threading;

namespace ThreadAssignment
{   //What are the methods used in Thread Class?
    //1.Abort() : This method is used to destroy threads by throwing ThreadAbortException
    //2.Interrupt() :This method interrupts the thread from a blocked state.
    //3.Join() :This method allows one thread to waituntil another thread completes its execution.
    //4.ResetAbort() :This method is responsible for cancelling the abort request of the current thread.
    //5.Resume() :Method is used to resume the suspended thread
    //6.Sleep() :This method is used to temporarily suspend the current execution of the thread for specefied milliseconds.
    //7.Start() :This method is used to send a thread into runnable state
    //8.Suspend() :Used to suspend the thread
    //9.Yield() :Another thread is processed.
    

    class Program
    {   static void TableOf2()
        {
            Console.WriteLine("Table of 2:");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*2);
            }
        }
        static void TableOf3()
        {
            Console.WriteLine("Table of 3:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 3);
            }

        }
        static void TableOf4()
        {
            Console.WriteLine("Table of 4:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 4);
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(TableOf2);
            Thread t2 = new Thread(TableOf3);
            Thread t3 = new Thread(TableOf4);
            //OUTPUT 1
            //t1.Start();
            //t1.Join();
            //t2.Start();
            //t2.Join();
            //t3.Start();
            //t3.Join();




            
            //OUTPUT 2
            t3.Start();
            t3.Join();
            t2.Start();
            t2.Join();
            t1.Start();
            t1.Join();

            ThreadProperties.CurrentThead();
            ThreadProperties.ManagedThreadId();
            ThreadProperties.ThreadPriorityCheck();
            ThreadProperties.ThreadSleep();

           


        }
    }
}
