using System;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primitive (Value) Types

            // Integer Types:
            sbyte sbytNumber = 10; // 8Bits
            short shrNumber = 300; // 16Bits
            int intNumber = 32000; // 32Bits
            long lngNumber = 2000000; // 64Bits

            // Or
            byte bytNumber = 10; // 8Bits
            ushort ushrNumber = 300; // 16Bits
            uint uintNumber = 32000; // 32Bits
            ulong ulngNumber = 2000000; // 64Bits

            //################################################
            int a = 10; // OK
            long b = 10; // OK (Implicit Casting)

            b = a; // OK (Implicit Casting)

            // a = b; // Compile Error!
            a = (int)b; // OK (Explicit Casting)

            //################################################
            // Decimal Types:
            double dblNumber = 123.456; // 64Bits (value will be rounded)

            float fltNumber1 = (float)3.14; // 32Bits (should CAST value)
            float fltNumber2 = 3.14f; // Or

            decimal decNumber1 = (decimal)123.456; // 64Bits (value will not be rounded + should CAST value)
            decimal decNumber2 = 123.456m; // Or

            //################################################
            int m = 1;
            int n = m + 1;

            //################################################
            int intResult = 10;
            // +, -, *, /, %

            intResult = intResult - 1;
            intResult -= 1;
            intResult--;
            --intResult;

            //################################################
            int p1 = 1;
            int q1 = p1++;
            int q2 = ++p1;

            //################################################
            bool blnResult = true; //  Or false

            //################################################
            char chrResult1 = 'A';

            //################################################
            int intNumber1 = 5;
            int intNumber2 = 7;
            int intMax = (intNumber1 < intNumber2) ? intNumber2 : intNumber1; // Inline Condition
            int intMin = (intNumber1 > intNumber2) ? intNumber2 : intNumber1;

            for (int intTemp = 0; intTemp <= 10; intTemp++)
            {
                Console.WriteLine("intTemp: {0}", intTemp);

                if (intTemp == 3)
                {
                    intTemp = 5;
                    continue;
                }

                if (intTemp == 8)
                {
                    break;
                }
            }
            // Result: 0, 1, 2, 3, 6, 7, 8

            //################################################
            // Reference Type
            string strFirstName = "Mahya";
            string strLastName = "Amiri";
            string strFullName = strFirstName + " " + strLastName;

            if (strFirstName == "Mahya")
            {
                Console.WriteLine("Your first name is Mahya");
            }
            else
            {
               Console.WriteLine("Your first name is not Mahya");
            }

            Console.ReadLine();
        }
    }
}


