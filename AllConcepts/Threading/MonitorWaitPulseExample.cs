using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AllConcepts
{
    /*Monitor.Wait method puts the thread from ready queue to wait queue.
     * Monitor.Pulse method put any of the thread from wait queue to ready queue.
     * Monitor.PulseAll put all the threads from waiting queue to ready queue and any of the ready queue thread can acquire the lock.
     * */
    public class MonitorWaitPulseExample
    {
        public void TestMonitorWaitPulseExample()
        {
            PingPong pp = new PingPong();
            Console.WriteLine("The Ball is dropped... \n");
            MyThread mythread1 = new MyThread("Ping", pp);
            MyThread mythread2 = new MyThread("Pong", pp);
            mythread1.thread.Join();
            mythread2.thread.Join();
            Console.WriteLine("\nThe Ball Stops Bouncing.");
            Console.ReadLine();

        }
    }

    class MyThread
    {
        public Thread thread;
        PingPong pingpongObject;
        //construct a new thread.
        public MyThread(string name, PingPong pp)
        {
            thread = new Thread(new ThreadStart(this.run));
            pingpongObject = pp;
            thread.Name = name;
            thread.Start();
        }
        //Begin execution of new thread.
        void run()
        {
            if (thread.Name == "Ping")
            {
                for (int i = 0; i < 5; i++)
                    pingpongObject.Ping(true);
                pingpongObject.Ping(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    pingpongObject.Pong(true);
                pingpongObject.Pong(false);
            }
        }
    }

    class PingPong
    {
        
        private object lockObj = new object();
        public void Ping(bool running)
        {
            lock (lockObj)
            {
                if (!running)
                {
                    //ball halts..
                    Monitor.Pulse(lockObj); //notify any waiting threads.
                    return;
                }

                Console.WriteLine("Ping");
                //if the Thread which has acquired the lock wants to release the lock it can issue Monitor.Pulse to notify waiting thread to acquire lock
                Monitor.Pulse(lockObj); //let pong run
                //Using Monitor.Wait thread goes into wait state. It will not acquire the lock until another thread which has 
                //acquired the lock issues Monitor.pulse
                Monitor.Wait(lockObj); //Wait for pong to complete
            }
        }

        public void Pong(bool running)
        {
            lock (lockObj)
            {
                if (!running)
                {
                    //ball halts..
                    Monitor.Pulse(lockObj); //notify any waiting threads.
                    return;
                }

                Console.WriteLine("Pong");
                Monitor.Pulse(lockObj); //let Ping run
                Monitor.Wait(lockObj); //Wait for Ping to complete
            }
        }
    }
}
