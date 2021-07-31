using System;

namespace Chapter22
{
    public class SomeClass
    {
        public int E;
        public readonly int F;

        private int _a;
        public int A // Read And Write Property
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
        public int B // Write Only Property
        {
            set
            {
                _b = value;
            }
        }

        private int _c;
        public int C // Read Only Property
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
            int intTemp = 0;
            SomeClass obj = new SomeClass();

            obj.A = 1; //write
            intTemp = obj.A; // read

            obj.B = 2;
            // Wrong 
            // intTemp = object1.B;

            // Wrong 
            // object1.C = 3;
            intTemp = obj.C;

            obj.E = 4;
            intTemp = obj.E;

            // Wrong 
            // object1.F = 5;

            intTemp = obj.F;

            Console.WriteLine(obj.F.ToString());
            System.Console.ReadLine();
        }
    }
}
