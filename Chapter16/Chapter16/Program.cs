using System;

namespace Chapter16
{
    public class Utility
    {
        public const int a = 10;
        public int b;
        public readonly int c;
        public readonly int d = 2;
        public readonly int e = 7;

        public Utility()
        {
            c = 1;
        }
        public Utility(int constant1, int constant2)
        {
            c = constant1;
            e = constant2;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int intNumber;
            Utility SomeObject = new Utility();

            // Wrong Usage!
            // Utilities.a = 2;     CONST
            intNumber = Utility.a;
            // Wrong Usage!
            // SomeObject.a = 2;
            // int intNumber = SomeObject.a;

            SomeObject.b = 1;
            intNumber = SomeObject.b;

            // Wrong Usage!
            // SomeObject.c = 2; // ReadOnly
            intNumber = SomeObject.c;

            System.Console.ReadLine();
    }
}
