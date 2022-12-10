using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.MultiThreading
{
    internal class Numbers
    {
        private int x, y;
        public Numbers(int x, int y)
        {
            this.y = y;
            this.x = x;
        }
        public void GetCurSituation()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"custom thread: {x}, {y}");
                Thread.Sleep(300);
            }

        }
    }
}
