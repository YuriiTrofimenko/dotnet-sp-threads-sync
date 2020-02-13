using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncDemo
{
    class Program
    {
        private static volatile string taskName1 = "N1";
        private static string taskName2 = "N2";
        static void Main(string[] args)
        {
            // v1
            /* Thread thread =
                new Thread(new ThreadStart(Program.MyTask));
            thread.Start();
            new Thread(() => { Console.WriteLine("MyTask2"); }).Start();
            //thread.Start(); Error!
            Console.WriteLine("End"); */

            // v2
            /* new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("MyTask1");
                }
            }).Start();
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("MyTask2");
                }
            }).Start(); */


            // v3
            /* new Thread(new ThreadStart(() => { MyTask(taskName1); })).Start();
            new Thread(new ThreadStart(() => { MyTask(taskName2); })).Start(); */

            // v4
            new Thread(new ParameterizedThreadStart(Program.MyTask)).Start(taskName1);
            new Thread(new ParameterizedThreadStart(Program.MyTask)).Start(taskName2);
        }

        /* static void MyTask() {
            Console.WriteLine("MyTask");
            new Thread(() => { Console.WriteLine("MyTask1-1"); }).Start();
        } */

        /* static void MyTask(string _taskName)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(_taskName);
            }
        } */

        static void MyTask(object _taskName)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(_taskName);
            }
        }
    }
}
