using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace CsvFile
{
    public class DataModel
    {
        public int val1 {  get; set; }
        public string val2 { get; set; }
    }
    public class TestDataModel
    {
        public void Test1()
        {
            List<DataModel> x = new List<DataModel>();
            for (int i = 0; i < 10; i++)
            {
                x.Add(new DataModel {val1=i,val2="Test"+i});
            }

            string path= @"C:\\Users\\abhil\\Desktop\MyFile.CSV";


            //using(FileStream file= new FileStream(path, FileMode.Create, FileAccess.Write))   //Csv Writer
            //{
            //    using(StreamWriter writer = new StreamWriter(file))
            //    {
            //        using (CsvWriter write= new CsvWriter(writer, CultureInfo.InvariantCulture))
            //        {
            //            write.WriteRecords(x);
            //        }
            //    }
            //}
            using (FileStream file1 = new FileStream(path, FileMode.Open, FileAccess.Read))   //CSV Reader
            {
                using (StreamReader Reader = new StreamReader(file1))
                {
                    using (CsvReader read = new CsvReader(Reader, CultureInfo.InvariantCulture))
                    {
                        var output = read.GetRecords<DataModel>();
                        foreach(var record in output)
                        {
                            Console.WriteLine(record.val1+" "+record.val2);

                        }
                        
                    }
                }
            }





        }
    }


}
