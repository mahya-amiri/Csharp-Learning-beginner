using System;

namespace Chapter20
{
    public class Utility
    {
        public static void Incr1(SomeClass myObject)
        {
            myObject.x++;
            myObject.y++;
        }
        public static void Incr2(SomeStruct myType)
        {
            myType.x++;
            myType.y++;
        }
        public static void Incr3(ref SomeStruct myType)
        {
            myType.x++;
            myType.y++;
        }
    }
    public class SomeClass
    {
        public int x;
        public int y;

        public void ShowValues()
        {
            System.Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }
    public struct SomeStruct
    {
        public int x;
        public int y;

        public void ShowValues()
        {
            System.Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass Obj1 = new SomeClass();
            Obj1.y = 10; Obj1.x = 5;
            Obj1.ShowValues();

            Utility.Incr1(Obj1);
            Obj1.ShowValues();

            SomeStruct type1;
            type1.x = 5;
            type1.y = 10;
            type1.ShowValues();

            Utility.Incr2(type1);
            type1.ShowValues();

            Utility.Incr3(ref type1);
            type1.ShowValues();

            System.Console.ReadLine();
        }
    }
}
