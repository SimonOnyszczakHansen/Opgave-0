using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TrådØvelser
{
    internal class Program
    {
        public void WorkThreadFunction()//Creates a method with a loop that runs 5 times
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
            }
        }
    }

    class threprog
    {
        static void Main(string[] args)
        {
            Program pg = new Program();//Creates an object for the class above
            Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));//Creates a thread using the method
            thread.Start();//runs the thread that we created
            Console.Read();
        }
    }
}
