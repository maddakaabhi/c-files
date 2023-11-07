using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public interface IVehicle
    {
        void Fly();
        void Drive();
    }
    public class flyingcar : IVehicle
    {
        public void Fly()
        {
            Console.WriteLine("car is flying");
        }
        public void Drive()
        {
            Console.WriteLine("driving a car");
        }


    }
    public class car : IVehicle 
    { 
        public void Fly()
        {
            throw new NotImplementedException();
        }
        public void Drive()
        {
            Console.WriteLine("Drive a car");
        }

    }
}
