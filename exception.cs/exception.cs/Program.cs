// See https://aka.ms/new-console-template for more information
using System;
class Vehicle
{
    public string name="mustang";
    public void Horn()
    {
        Console.WriteLine("Tuu Tuu");
    }
}
class Car : Vehicle
{
    public string modelname = "Ford";
}
class Motor : Vehicle
{
    public string modelname = "KTM";
}
class Program
{
    static void Main(string[] args)
    {
       
        Car car = new Car();
        Console.WriteLine(car.name);
        Console.WriteLine(car.modelname);
        car.Horn();
        Motor motor = new Motor();
        Console.WriteLine(motor.modelname);
        Console.WriteLine(motor.name);
        motor.Horn();

    }
}