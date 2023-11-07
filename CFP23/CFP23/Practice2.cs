using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CFP23
{

    public class Practice2
    {

        //public void showMatch(string text, string expr)
        //{
        //    Console.WriteLine("The Expression: " + expr);
        //    MatchCollection mc = Regex.Matches(text, expr);
        //    foreach (Match m in mc)
        //    {
        //        Console.WriteLine(m);
        //    }
        //}
        ////problem1
        //public void Test1()
        //{
        //    string input = " abbb aabb abab aaab";
        //    string pattern = @"ab{2,3}";
        //    MatchCollection x = Regex.Matches(input, pattern);
        //    foreach (Match m in x)
        //    {
        //        Console.WriteLine(m);
        //    }
        //}
        //public void Test2()
        //{
        //    string input1 = "this_is_a_sample_text with_multiple_words_separated_by_underscores";
        //    string pattern = @"[a-z]+_[a-z]*";
        //    MatchCollection y = Regex.Matches(input1, pattern);
        //    foreach (Match m in y)
        //    {
        //        Console.WriteLine(m);
        //    }
        //}
        //public void Test3()
        //{
        //    string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression. </p>";

        //    string pattern = @"<[^>]*>";

        //    MatchCollection z = Regex.Matches(input, pattern);

        //    foreach (Match match in z)
        //    {
        //        Console.WriteLine(match);
        //    }
        //}
        //public void Test4()
        //{
        //    string input = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox";
        //    string pattern = @"fox[es]?";
        //    MatchCollection y = Regex.Matches(input, pattern);
        //    Console.WriteLine("No of Occurances are " + y.Count);
        //}
        //public void Test5()
        //{
        //    string[] str = new string[] {"image1.jpg",
        //                                "my_photo.png",
        //                                "logo.ico",
        //                                "document.docx",
        //                                "picture.tiff",
        //                                "image2.gif"};
        //    string pattern = @"^.+[jpg|png|docx]$";
        //    foreach (string fileName in str)
        //    {
        //        if (Regex.IsMatch(fileName, pattern, RegexOptions.IgnoreCase))
        //        {
        //            Console.WriteLine(fileName + " is a valid image file.");
        //        }
        //        else
        //        {
        //            Console.WriteLine(fileName + " is not a valid image file.");
        //        }
        //    }


        //}
        //public void Test6()
        //{
        //    string input = "https://www.google.com";
        //    string pattern = @"^(https|http)://[www]+\.[a-z A-Z.]+[a-z]{2,3}";
        //    bool x = Regex.IsMatch(input, pattern);
        //    Console.WriteLine(x);
        //}
        //public void Test7()
        //{
        //    string[] a = { "Hello", "How", "Here", "jhdgvc", "dxcc" };
        //    string pattern = @"^H\S*e$";
        //    foreach (string v in a)
        //    {
        //        MatchCollection y = Regex.Matches(v, pattern);
        //        foreach (Match m in y)
        //        {
        //            Console.WriteLine(m);
        //        }
        //    }
        //}
        //public void Test8()
        //{
        //    string x = "abhimaddaka@gmail.com";
        //    string pattern = @"[a-z 0-9]+\@[a-z]+\.[a-z]{2,3}";
        //    bool x1= Regex.IsMatch(x, pattern);
        //    Console.WriteLine(x1);
        //}

        public void Test9()
        {
            string x = "l0E1N5cJFmGo4QgD";
            string pattern = @"[a-z A-Z 0-9 . ,]+[- _ ! @ # $ ^ & * ]{8,}";
            bool x1 = Regex.IsMatch(x, pattern);
            if (x1 == true)
            {
                Console.WriteLine("Password is stronger");
            }
            else
            {
                Console.WriteLine("Weak Password");

            }


        }
        
    }
}




