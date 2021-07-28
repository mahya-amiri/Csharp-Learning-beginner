using System;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            goto MyLable;

        MyLable:
            Console.WriteLine("Hello World!");

            //################################################
            // Array 
            int[] intNumbers1 = new int[5];
            intNumbers1[0] = 10;
            intNumbers1[1] = 20;
            intNumbers1[4] = 50;

            int[] intNumbers2 = { 10, 20, 30, 40, 50 }; //Or

            //#################################################
            Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= 4; intIndex++)
            {
                Console.WriteLine("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################
            int intNumberCount = 5;

            int[] intNumbers3 = new int[intNumberCount];

            intNumbers3[0] = 10;
            intNumbers3[1] = 20;
            intNumbers3[2] = 30;
            intNumbers3[3] = 40;
            intNumbers3[4] = 50;

            Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= intNumberCount - 1; intIndex++)
            {
                Console.WriteLine("Array[{0}]: {1}", intIndex, intNumbers3[intIndex]);
            }

            //#################################################
            Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= intNumbers2.Length - 1; intIndex++)
            {
                Console.WriteLine("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################
            Console.WriteLine("\n");
            for (int intIndex = intNumbers2.Length - 1; intIndex >= 0; intIndex--)
            {
                Console.WriteLine("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################
            Console.WriteLine("\n");
            for (int intIndex = intNumbers2.Length - 1; intIndex >= 0; intIndex--)
            {
                intNumbers2[intIndex]++;
                Console.WriteLine("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################
            Console.WriteLine("\n");
            foreach (int intNumber in intNumbers2) // ReadOnly
            {
                Console.WriteLine("Array Value is {0}", intNumber);
            }
        }
    }
}

