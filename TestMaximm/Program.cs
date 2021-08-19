using System;

namespace TestMaximm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Testmaximum program");
            int M = FindMximum.FindIntNumber(10, 9, 9);
            Console.WriteLine("maximum value for test case 1 is " + M);
            //int M2 = FindMximum.FindIntNumber(8, 9, 7);
            //Console.WriteLine("maximum value for test case 2 is " + M2);
            //int M3 = FindMximum.FindIntNumber(10, 9, 69);
            //Console.WriteLine("maximum value for testcase 3 is " + M3);
        }
    }
}
