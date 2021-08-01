using System;

namespace Chapter23
{
    public class Complex
    {
        public int X;
        public int Y;

        public Complex()
        {
        }
        public Complex(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Show()
        {
            Console.WriteLine("{0} + {1}i", X, Y);
        }
        // Operator Overloading
        public static Complex operator +(Complex m, Complex n)
        {
            Complex oResult = new Complex();
            oResult.X = m.X + n.X;
            oResult.Y = m.Y + n.Y;
            return (oResult);
            //Or return(new Complex(m.X + n.X, m.Y + n.Y));
        }
        public static Complex operator *(int alpha, Complex m)
        {
            return (new Complex(alpha * m.X, alpha * m.Y));
            //Or Complex oResult = new Complex();
            // oResult.X = alpha * m.X;
            // oResult.Y = alpha * m.Y;
            //return (oResult);
        }
        public static bool operator ==(Complex m, Complex n)
        {
            if ((m.X == n.X) && (m.Y == n.Y))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public static bool operator !=(Complex m, Complex n) // Operator Overloading!
        {
            if ((m.X == n.X) && (m.Y == n.Y))
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Complex oc1 = new Complex();
            //Complex oc2 = new Complex();
            //Console.WriteLine(oc1 == oc2);
            //oc1.X = 1; 
            //oc1.Y = 1; 
            //oc2.X = 1; 
            //oc2.Y = 1;

            Complex A = new Complex();
            A.X = 1;
            A.Y = 2;
            A.Show();

            Complex B = new Complex(3, 4);
            B.Show();

            System.Console.WriteLine("\n----------");

            Complex C = A + B;
            C.Show();

            System.Console.WriteLine("\n----------");

            C += A;
            C.Show();

            System.Console.WriteLine("\n----------");

            int alpha = 5;
            C = alpha * A;
            C.Show();

            System.Console.WriteLine("\n----------");

            Complex D = new Complex(1, 2);

            if (A == D)
            {
                System.Console.WriteLine("A is equal to D");
            }
            else
            {
                System.Console.WriteLine("A is not equal to D");
            }

            System.Console.WriteLine("\n----------");

            if (A != B)
            {
                System.Console.WriteLine("A is not equal to B");
            }
            else
            {
                System.Console.WriteLine("A is equal to B");
            }

            System.Console.ReadLine();
        }
    }

}
