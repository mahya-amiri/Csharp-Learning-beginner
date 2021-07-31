using System;

namespace Chapter18
{
    public enum PersonGenders
    {
        Male, //0
        Female
    }
    public enum PersonMarriages : byte
    {
        Single = 10,
        Married = 20,
        Divorced = 30
    }

    public enum SomeEnum
    {
        X = 10,
        Y, // Y = 11,
        Z, // Z = 12,
        T  // T = 13
    }
    public class Person
    {
        public int Age;
        public string FullName;

        public PersonGenders Gender;
        public PersonMarriages Marriage;

        public Person()
        {
        }

        public Person
            (string fullName, int age, PersonGenders gender, PersonMarriages marriage)
        {
            Age = age;
            Gender = gender;
            Marriage = marriage;
            FullName = fullName;
        }

        public Person(Person person)
        {
            Age = person.Age;
            Gender = person.Gender;
            Marriage = person.Marriage;
            FullName = person.FullName;
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n: Full Name: {0}, Age: {1}, Gender: {2}, Marriage: {3}", FullName, Age, Gender, Marriage);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person P0 = new Person();
            P0.Marriage = PersonMarriages.Married;

            Person P1 = new Person("Mahya Amiri", 23, PersonGenders.Male, PersonMarriages.Single);
            P1.ShowInfo();

            Console.WriteLine("\n----------");

            Person P2 = new Person(P1);
            P2.ShowInfo();

            Console.WriteLine("\n----------");

            if (P1.Gender == PersonGenders.Male)
            {
                Console.WriteLine("He is male.");
            }
            else
            {
                Console.WriteLine("She is female.");
            }

            switch (P1.Marriage)
            {
                case PersonMarriages.Single:
                    {
                        Console.WriteLine("Single.");
                        break;
                    }

                case PersonMarriages.Married:
                    {
                        Console.WriteLine("Married.");
                        break;
                    }

                case PersonMarriages.Divorced:
                    {
                        Console.WriteLine("Divorced.");
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
