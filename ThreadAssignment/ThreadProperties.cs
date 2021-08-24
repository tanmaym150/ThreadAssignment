using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadAssignment
{
    public class ThreadProperties
    {  
       public static void CurrentThead()
        {   //Gives the name of current thread.
            Thread thr;
            thr = Thread.CurrentThread;
            thr.Name = "IX Thread";
            Console.WriteLine("The name of the current thread is :{0}",thr.Name);
            Console.WriteLine("Is the {0} alive? :{1}",thr.Name,thr.IsAlive);
           


        }
        public static void ManagedThreadId()
        {
            Thread t4 = new Thread(new ThreadStart(ManagedThreadId));
            Console.WriteLine("The managed thread id of thread IX is:{0}",t4.ManagedThreadId);
        } 
        public static void ThreadPriorityCheck()
        {
            Thread t11 = new Thread(ThreadPriorityCheck);
            Thread t12 = new Thread(ThreadPriorityCheck);
            Thread t13 = new Thread(ThreadPriorityCheck);

            //setting the priority of thread
            t12.Priority = ThreadPriority.Highest;
            t13.Priority = ThreadPriority.BelowNormal;

            Console.WriteLine("The priority of t11 is:{0}",t11.Priority);//normal-2
            Console.WriteLine("The priority of t12 is:{0}", t12.Priority);//highest-4
            Console.WriteLine("The priority of t13 is:{0}", t13.Priority);//belownormal-0

            //ThreadState
            Console.WriteLine("the threadstate of t12 is: {0}  ",t12.ThreadState);//unstarted




        }
        public static void ThreadSleep()
        {
            Thread ts = new Thread(ThreadSleep);
           
            for(int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Thread.Sleep(2000);
                }
                Console.WriteLine(i);
            }
        }
    }
}
