using System;

namespace Chpter19
{
    public enum FileAttributes
    {
        Hidden = 1, 
        System = 2, 
        Archive = 4, 
        Readonly = 8, 
        Compressed = 13 
    }
    public class File
    {
        public string FileName;
        public FileAttributes Attribute;

        //costructors
        public File(string fileName)
        {
            FileName = fileName;
        }

        public File(string fileName, FileAttributes attribute)
        {
            FileName = fileName;
            Attribute = attribute;
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n Filename: {0}, Attribute: {1}.", FileName, Attribute);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            File oFile = new File("Temp.tmp");

            int a = (4 | 8 | 1);
            oFile.Attribute = FileAttributes.Readonly;
            oFile.Attribute = FileAttributes.Readonly | FileAttributes.Archive | FileAttributes.Hidden;

            if (oFile.Attribute == FileAttributes.Hidden)
            {
                System.Console.WriteLine("This file is Hidden");
            }
            else
            {
                System.Console.WriteLine("This file is not Hidden");
            }
            // Wrong 
            // if (oFile.Attribute & FileAttributes.Hidden == FileAttributes.Hidden)
            if ((oFile.Attribute & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                System.Console.WriteLine("This file is Hidden");
            }
            else
            {
                System.Console.WriteLine("This file is not Hidden");
            }
        }
    }
}
