using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMultithreding
{
    public class Program
    {
        public void First()
        {
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void Second()
        {
            for(int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
    public class MultitherdingMM
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Thread t1 = new Thread(new ThreadStart(program.First));
            Thread t2=new Thread(new ThreadStart(program.Second));
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
          //  t1.Join();
            t1.Join(5000);
            t2.Start();
        }
    }
}
