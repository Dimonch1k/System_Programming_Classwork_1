using System;
using System.Threading;

namespace SystemProgramming_1
{
    internal class Program
    {
        public static int num = 0;

        public static void printHelloWorld()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("\t\t\tHello World");
            //}

            num += 10;
        }


        static void Main(string[] args)
        {
            for (int j = 0; j < 100; j++)
            {

                Thread thread = new Thread(() => printHelloWorld());
                thread.Priority = ThreadPriority.Highest;
                thread.Start();

                //for (int i = 0; i < 100; i++)
                //{
                //    Console.WriteLine("Hello World");
                //}


                Thread[] threads = new Thread[10];

                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i] = new Thread(() => printHelloWorld());
                    threads[i].Start();
                }

                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
