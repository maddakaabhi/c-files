using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Collectons
{
    public class Comparable  //IComparable<Comparable>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }

        //    public int CompareTo(Comparable other)        //it is used when source is not known
        //    {
        //        if (this.Sid > other.Sid)
        //            return 1;
        //        else if (this.Sid < other.Sid)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //}
        //class Comparestudent : IComparer<Comparable>             //one of method using comparer 
        //{
        //    public int Compare(Comparable x, Comparable y)
        //    {
        //        if(x.Class > y.Class)
        //            return 1;
        //        else if (x.Class < y.Class)
        //            return -1;
        //        else 
        //            return 0;
        //    }
        //}
        //class TestComparable
        //{
        //    public static int Comparenames(Comparable s1, Comparable s2)       //method to sort on strings
        //    {
        //        return s1.Name.CompareTo(s2.Name);
        //    }
        static void Main(string[] args) 
        {
            Comparable x=new Comparable { Sid = 3,Name="Abhi",Class=10 };
            Comparable y = new Comparable { Sid = 2, Name = "Hello", Class = 8 };
            Comparable z = new Comparable { Sid = 5, Name = "Hi", Class = 7 };



            List<Comparable> li= new List<Comparable> { x,y,z };  //Another way of adding data
            var arr1=li.OrderBy(x=>x.Name);
            foreach(Comparable a in arr1)
                Console.WriteLine(a.Sid+" "+a.Name+" "+a.Class);
            //li.Sort();
            //foreach (Comparable a in li)
            //    Console.WriteLine(a.Sid + " " + a.Name + " " + a.Class);
            ////Another method
            ////create instance for CompareStudent
            //Comparestudent obj = new Comparestudent();
            ////li.Sort(obj);          =>this is one method
            //li.Sort(1, 2, obj);     //=>this one more method with start,end indexes


            //foreach (Comparable a in li)
            //    Console.WriteLine(a.Sid+ " "+a.Name+ " "+a.Class);

            //Comparison<Comparable> b = new Comparison<Comparable>(Comparenames);     //comparing strings to sort
            //li.Sort(b);

            //foreach (Comparable a in li)
            //    Console.WriteLine(a.Sid + " " + a.Name + " " + a.Class);







        }
    }
}
