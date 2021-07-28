using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    public class Person
    {
        public int Age;
        public string FullName;

        // Default Constructor
        public Person() 
        {
            Age = 23;
            FullName = "";
        }

        public Person(int age,string fullName)
        {
            this.Age = age;
            this.FullName = fullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person P0 = new Person();
            P0.ShowInfo();

            Person P = new Person();
           
            P.FullName = "Ali Amiri";
            P.ShowInfo();

            Person P1 = new Person(21, "Amir Amiri");
            P1.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
