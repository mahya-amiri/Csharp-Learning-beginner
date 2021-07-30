using System;

namespace Chapter14
{
    public class SomeClass
    {
        public int x;
        private int _y;

        public static int m;
        private static int _n;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass.m = 20;
            SomeClass obj = new SomeClass();
            obj.x = 10;
            Console.ReadLine();
        }
    }
}
