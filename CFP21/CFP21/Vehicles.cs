using System;
using System.Collections.Generic;
using System.Text;

namespace CFP21
{
    public class Vehicles
    {
        public string make,model;
        public int year;
        public void display()
        {
            Console.WriteLine(make+" "+year+" "+model);
        }
    }
    public class cars:Vehicles
    {
        public cars(string make,string model,int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

    }
    public class Bycycles:Vehicles
    {
        public Bycycles(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

    }
    public class Motorcycles : Vehicles
    {
        public Motorcycles(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

    }
}
