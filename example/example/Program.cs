using System;
class program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        var querysyntax = (from i in list
                           where i > 5
                           select i).ToList();
        var methodsyntax = list.Where(i => i > 5).ToList();
        foreach(var item in querysyntax)
        {
            Console.WriteLine(item);
        }
        foreach (var item in methodsyntax)
        {
            Console.WriteLine(item);
        }
    }
}