using System;

namespace Chapter22
{
    public class SomeClass
    {
        public int E;
        public readonly int F;

        private int _a;
        public int A // Property <-> Read And Write Property!
        {
            get
            {
                return (_a);
            }
            set
            {
                _a = value;
            }
        }

        private int _b;
        public int B // Write Only Property!
        {
            set
            {
                _b = value;
            }
        }

        private int _c;
        public int C // Read Only Property!
        {
            get
            {
                return (_c);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
