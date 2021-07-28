using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you have: ");
            string strNumberCount = Console.ReadLine();
            int intNumberCount = Convert.ToInt32(strNumberCount);

            int[] intNumbers = new int[intNumberCount];

            //System.Console.Write("\n\r");
            System.Console.Write(System.Environment.NewLine);

            for (int intIndex = 0; intIndex <= intNumbers.Length - 1; intIndex++)
            {
                System.Console.Write("[{0}]: ", intIndex + 1);
                string strNumber = System.Console.ReadLine();
                int intNumber = System.Convert.ToInt32(strNumber);

                intNumbers[intIndex] = intNumber;
            }

            int intSum = 0;
            foreach (int intNumber in intNumbers)
            {
                intSum += intNumber;
            }

            System.Console.WriteLine(System.Environment.NewLine);

            for (int intIndex = intNumbers.Length - 1; intIndex >= 0; intIndex--)
            {
                System.Console.WriteLine
                    ("Number of {0} is {1}.", intIndex + 1, intNumbers[intIndex]);
            }

            System.Console.WriteLine(System.Environment.NewLine);

            System.Console.WriteLine("The sum of these numbers is {0}.", intSum);

            System.Console.ReadLine();
        }
    }
}
