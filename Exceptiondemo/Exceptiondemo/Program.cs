// See https://aka.ms/new-console-template for more information
public class Dividebyoddexception : ApplicationException      //creating application exception
{
    public override string Message                           //overiding message
    {
        get {
            return "Divide by an odd number";
        }
    }
}

class Program : Dividebyoddexception              //inheriting the Application Exception
{
    static void Main(string[] args)
    {
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 > 0)
            {
                throw new Dividebyoddexception();
            }
            int z = a / b;
            Console.WriteLine(z);
        }
        catch ( DivideByZeroException ex1)        //System Exception
        {
            Console.WriteLine(ex1.Message);
        }
        catch ( FormatException ex ) { 
        Console.WriteLine(ex.Message);
        }
        catch( Exception ex )               //default exception
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Code executed");
        }
        Console.WriteLine("End of the program executed");
    
    }
}
