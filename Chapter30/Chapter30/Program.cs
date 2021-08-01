using System;

namespace Chapter30
{
    public sealed class Supervisor // Singletone Pattern
    {
        private static Supervisor _instance = null;
        public static Supervisor GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Supervisor();
            }
            return (_instance);
        }

        private Supervisor()
        {
        }

        public int Age;
        public string FullName;

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Supervisor od = Supervisor.GetInstance();

            od.Age = 21;
            od.FullName = "aa";
            od.ShowInfo();


            Supervisor.GetInstance().Age = 40;
            Supervisor.GetInstance().FullName = "Ali Abbasi";
            Supervisor.GetInstance().ShowInfo();

            Supervisor S = Supervisor.GetInstance();



            S.Age = 25;
            S.ShowInfo();
            od.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
