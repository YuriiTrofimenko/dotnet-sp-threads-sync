using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSyncDemo
{
    class Actor
    {
        public Data data;
        public Actor(Data data)
        {
            this.data = data;
        }
        public static void IncreaseStatic() {

            Data.countStatic++;

        }
        public void Increase()
        {
            this.data.count++;
        }
    }
}
