using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CFP27FILEHandling
{
    public class CheckFile
    {
        public void Checkingfile()
        {
            string path = @"C:\\Users\\abhil\\Desktop\SampleFile.txt";
            if (File.Exists(path))  //checking file exist or not
            {
                Console.WriteLine("File Exist");//if exists
                string data=File.ReadAllText(path);   //reading data in the existing file
                Console.WriteLine(data);

            }
            else
            {
                Console.WriteLine("File doen't exist");
            }
            string path2 = @"C:\\Users\\abhil\\Desktop\SampleFile1.txt";
            File.Copy(path, path2);
            Console.ReadLine();
            

        }
    }
}
