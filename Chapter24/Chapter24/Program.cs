using System;
using System.Text;

namespace Chapter24
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            str1 = "Mahya";
            string str2 = "Mahsa";
            str1 = "Amir Ali";
            Console.WriteLine("First Char os str1: {0}", str1[0]);
            // Wrong 
            // str1[0] = 'M';

            // Wrong
            // str1 = "C:\Windows\System32";
            str1 = "C:\\Windows\\System32";
            str1 = @"C:\Windows\System32";

            if (str1 == str2)
            {
                Console.WriteLine("Two strings are similar");
            }
            if (string.Compare(str1, str2, false) == 0) 
            {
                Console.WriteLine("Two strings are similar");
            }

            string[] aryStrings;
            str1 = "Hello,How;Are,You";
            aryStrings = str1.Split(',', ';');

            foreach (string str in aryStrings)
            {
                System.Console.WriteLine("{0}", str);
            }
            Console.WriteLine("\n----------");

            System.Text.StringBuilder oStringBuilder = new System.Text.StringBuilder();

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length);      // 0
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity);    // 16 Characters
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString());  // ""

            System.Console.WriteLine("\n----------");

            oStringBuilder.Append("Hello");

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 5
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 16
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString()); // "Hello"

            System.Console.WriteLine("\n----------");

            oStringBuilder.Append("How Are You? My name is Mahya Amiri.");

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 48
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 48
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString()); 

            System.Console.WriteLine("\n----------");

            oStringBuilder.Remove(0, oStringBuilder.Length);

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 0
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 48
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity);
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString());

            System.Console.ReadLine();
        }
    }
}
