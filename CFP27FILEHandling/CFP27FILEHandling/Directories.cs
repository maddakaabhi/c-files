using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection.PortableExecutable;

namespace CFP27FILEHandling
{
    public class Directories
    {
        public void Test2()
        {
            //string path= @"C:\\Users\\abhil\\Desktop\\Sampledir1";
            string path1 = @"C:\\Users\\abhil\\Desktop\\Sampledir3";

            DirectoryInfo dir = new DirectoryInfo(path1);
            /*dir.Create();*/     //create a directory
            //dir.CreateSubdirectory("Sampledir");   //create a sub directory inside a directory
            /*dir.MoveTo(path1);*/      //movind Path1 directory to path directory
            DirectoryInfo[] dir1= dir.GetDirectories();
            foreach (DirectoryInfo dir2 in dir1)
            {
                Console.WriteLine(dir2.Name);
                Console.WriteLine(dir2.FullName);
                Console.WriteLine(dir2.CreationTime);
                Console.WriteLine(dir2.LastAccessTime);
                Console.WriteLine(dir2.Attributes);
                Console.WriteLine(dir2.Parent);
                Console.WriteLine(dir2.Root);
            }
            //Console.WriteLine("Directory created successfully");

        }
    }
}
