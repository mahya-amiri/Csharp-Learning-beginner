using System;

namespace Chapter11
{
    public class Father
    {
        public int Age;
        public string FullName;
        public bool Angry;
        private int _criticalAmount;

        public Father()
        {
            Angry = false;
            _criticalAmount = 5000;
        }

        public void GiveMeMoney(int amount)
        {
            if (amount >= _criticalAmount)
            {
                Angry = true;
            }
            else
            {
                Angry = false;
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
            Father F1 = new Father();
            F1.Age = 20;
            F1.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);
            F1.GiveMeMoney(1000);
            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);
            F1.GiveMeMoney(5500);
            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);

            System.Console.ReadLine();
        }
    }
}
