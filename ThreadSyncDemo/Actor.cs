using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncDemo
{
    class Actor
    {
        private static Mutex mutex = new Mutex();
        public Data data;
        public Actor(Data data)
        {
            this.data = data;
        }
        public static void IncreaseStatic() {
            //mutex.WaitOne();
            Data.countStatic++;
            //mutex.ReleaseMutex();
        }
        public void Increase()
        {
            this.data.count++;
        }
    }
}
