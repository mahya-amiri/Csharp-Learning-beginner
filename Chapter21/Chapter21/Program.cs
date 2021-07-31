using System;

namespace Chapter21
{
    public class Person
    {
        public int X;

        public Person()
        {
        }
        
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }

        private int _age;
        //property
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
                if ((value >= 0) && (value <= 99))
                {
                    _age = value;
                }
            }
        }

        private string _fName;
        public string FirstName
        {
            get
            {
                return (_fName);
            }
            set
            {
                _fName = value;
            }
        }

        private string _lName;
        public string LastName
        {
            get
            {
                return (_lName);
            }
            set
            {
                _lName = value;
            }
        }

        public string FullName
        {
            get
            {
                // return ((_fName + " " + _lName).Trim()));
                return ((FirstName + " " + LastName).Trim());
            }
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
            Person p0 = new Person();
            p0.Age = 23;
            System.Console.WriteLine("Age: {0}", p0.Age);

            Person P1 = new Person();
            P1.Age = 20;
            P1.FirstName = "Mahya";
            P1.LastName = "Amiri";
            P1.ShowInfo();

            Person P2 = new Person("Sara", "Ahmadi", 30);
            Console.WriteLine(P2.FullName);

            System.Console.ReadLine();
        }
    }
}
