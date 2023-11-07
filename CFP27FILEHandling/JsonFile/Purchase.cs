using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonFile
{
    public class Purchase
    {
        public string productname {  get; set; }
        public int price { get; set; }

    }
    public class TestPurchase
    {
        public void Test4()
        {
            List<Purchase> list = new List<Purchase>();
            list.Add(new Purchase { productname = "Atta", price = 40 });
            list.Add(new Purchase { productname = "rice", price = 50 });
            list.Add(new Purchase { productname = "dhall", price = 100 });

            string filepath = @"C:\\Users\\abhil\\Desktop\Jsonfile.json";

            //using (FileStream file = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            //{
            //    using(StreamWriter writer = new StreamWriter(file))
            //    {
            //        var jsonstring = jsonserializer.serialize(list);
            //        writer.Write(jsonstring);
            //        Console.WriteLine("Data is stored into the file");
            //    }

            //}
            using(FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader  reader = new StreamReader(file))
                {
                    var jsonstring = reader.ReadToEnd(); 
                    var purchases= JsonSerializer.Deserialize<List<Purchase>>(jsonstring);
                    foreach(var purchase in purchases)
                        Console.WriteLine(purchase.productname+" "+purchase.price);
                }
            }



        }
    }

}
