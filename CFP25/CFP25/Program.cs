using System;

namespace CFP25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User x = new User();
            //string y=x.Test1("Hello", "World");
            //Console.WriteLine(y);
            //MoodAnalyser x = new MoodAnalyser();
            //string message = null;
            //Console.WriteLine(x.MoodAnalyserTest1(message));
            TestString x = new TestString();
            Console.WriteLine("enter the string");
            string y = null;                    //in this case if we give directly null it calls exception 
                                                 // if we give null through console, it will not work
            Console.WriteLine(x.Test1(y));




        }
    }
}
