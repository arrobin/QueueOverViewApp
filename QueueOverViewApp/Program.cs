using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOverViewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Hellow");
            myQueue.Enqueue("Robin");

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            Console.ReadKey();
        }
    }
}
