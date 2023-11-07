using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFP4_11review
{
    public class Transactions
    {
        public string category {  get; set; }
        public int sales { get; set; }

        public double rating { get; set; }


    }
    public class TestTransactions
    {
        public void Test2()
        {
            List<Transactions> list = new List<Transactions>();
            list.Add(new Transactions { category="Atta",sales=30,rating=4.5});
            list.Add(new Transactions { category = "Atta", sales = 30, rating = 4.5 });
            list.Add(new Transactions { category = "dhall", sales = 40, rating = 4.3 });
            list.Add(new Transactions { category = "ginger", sales = 20, rating = 4.2 });
            list.Add(new Transactions { category = "garlic", sales = 10, rating = 4.1 });
            list.Add(new Transactions { category = "Powder", sales = 500, rating = 4.4 });

            var y = list.Sum(x => x.sales);
            Console.WriteLine("Total number of sales="+y);

            var z= list.Sum(x => x.rating);
            Console.WriteLine("Total rating of all products="+z);

            var d = from i in list where i.category == "dhall" select i.rating;
            foreach (var i in d)
                Console.WriteLine(i);






        }
    }
            
}
