using System;
using System.Collections.Generic;
using System.Text;

namespace CFP4_11review
{
    public class Book
    {
        public string title="geetanjali";
        public string author="rabindranath";
        public int price=500;
        public int publishedyear=1970;
       
       
        //public Book(string title, string author, int price, int publishedyear)
        //{
        //    this.title = title;
        //    this.author = author;
        //    this.price = price;
        //    this.publishedyear = publishedyear;
        //}
        public string _title { get { return title; } set { _title = value; } }
        public string _author { get { return author; } set { _author= value; } }
        public int _price { get {  return price; } set { price = value; } }
        public int _publishedyear { get {  return publishedyear; } set {  publishedyear = value; } }


        public void TestBook()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(price);
            Console.WriteLine(publishedyear);
        }
    }
}
