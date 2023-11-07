using System;
class Animal
{
    public virtual void animalsound()
    {
        Console.WriteLine("Hello");
    }
}
class Pig : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("wee wee");
    }
}
class Dog : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("Bow Bow");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.animalsound();
        Animal pig = new Pig();
        pig.animalsound();
        Animal dog = new Dog();
        dog.animalsound();
    }
}
