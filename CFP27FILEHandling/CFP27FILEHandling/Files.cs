using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CFP27FILEHandling
{
    public class Files
    {
        public void Test3()
        {
            string path = @"C:\\Users\\abhil\\Desktop\\myfile.txt";
            //using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write))
            //{

            //    /*sw.WriteByte(65); */ // writing A character into file
            //                           //sw.WriteByte(67);
            //                           //string data = "You are good";
            //                           //Byte[] byte_data= Encoding.UTF8.GetBytes(data);
            //                           //sw.Write(byte_data, 0, byte_data.Length);

            //    using (StreamWriter writer = new StreamWriter(sw, Encoding.UTF8))   //used to write data into file
            //    {
            //        writer.WriteLine("Learning Never Ends");
            //    }
            //}

            using (FileStream sw = new FileStream(path, FileMode.Open, FileAccess.Read))
            {

                using (StreamReader reader = new StreamReader(sw))
                {

                    string line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
                Console.WriteLine("File created Sucessfully");



            }
        }
    }
}
