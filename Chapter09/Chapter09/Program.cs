using System;

namespace Chapter09
{
    public class Person
    {
        public int Age;
        public string FullName;

        private int _somePrivateField1;
        int _somePrivateField2; 

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }


        public void ShowInfo()
        {
            _somePrivateField1 = 20;
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Wrong
            // Person P = new Person();
            // P.Age = 20;
            // P.FullName = "Ali Reza Alavi";
            // P.ShowInfo();

            Person P = new Person("Sara Ahmadi", 30);
            P.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
