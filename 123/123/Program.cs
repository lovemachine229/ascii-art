using System;
using System.IO;
using System.Threading;
namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("♥");
                Thread.Sleep(40);
            }



            Console.ReadKey();
            Console.WriteLine("Loading... 0%");
            Thread.Sleep(1000);
            Console.WriteLine("Loading... 10%");
            Thread.Sleep(300);
            Console.WriteLine("Loading... 20%");
            Thread.Sleep(300);
            Console.WriteLine("Loading... 30%");
            Thread.Sleep(200);
            Console.WriteLine("Loading... 40%");
            Thread.Sleep(200);
            Console.WriteLine("Loading... 50%");
            Thread.Sleep(200);
            Console.WriteLine("Loading... 60%");
            Thread.Sleep(100);
            Console.WriteLine("Loading... 70%");
            Thread.Sleep(100);
            Console.WriteLine("Loading... 80%");
            Thread.Sleep(100);
            Console.WriteLine("Loading... 90%");
            Thread.Sleep(100);
            Console.WriteLine("Loading... 99%");
            Thread.Sleep(1000);
            Console.WriteLine("Loading... 100%");
            Thread.Sleep(100);
            using (StreamReader reader = new StreamReader(@"nga.txt"))
            {
                String s;

                {
                    while ((s = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        Thread.Sleep(100);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
