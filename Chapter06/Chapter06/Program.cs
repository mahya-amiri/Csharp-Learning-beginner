using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    public class Person
    {
        public int Age;
        public string FullName;

        public void ShowInfo()
        {
            System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Wrong 
            // Person P;
            // P.Age = 20;
            // P.FullName = "Ali Reza Alavi";
            // P.ShowInfo();

            Person P1;
            P1 = new Person();
            P1.Age = 20;
            P1.FullName = "Ali Reza Alavi";
            P1.ShowInfo();

            System.Console.WriteLine("\n");

            Person P2 = new Person();
            P2.Age = 30;
            P2.FullName = "Sara Ahmadi";
            P2.ShowInfo();

            System.Console.WriteLine("\n");

            Person P3;
            P3 = P1;
            P3.ShowInfo();

            System.Console.WriteLine("\n");

            Person P4 = P2;
            P4.ShowInfo();

            System.Console.WriteLine("\n");

            Person P5 = P1;
            P5.Age = 21;
            P5.ShowInfo();
            P1.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
