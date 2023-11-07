// See https://aka.ms/new-console-template for more information
using System;
class Employee
{
    int eno;
    double salary;
    string fname, dname, location;
    public Employee(int eno,double salary, string fname, string dname, string location)
    {
        this.eno = eno;
        this.salary = salary;
        this.fname = fname;
        this.dname = dname;
        this.location = location;
    }

    public object this[int index]
    {
        get
        {
            if (index == 1)
                return eno;
            else if (index == 2)
                return salary;
            else if (index == 3)
                return fname;
            else if (index == 4)
                return dname;
            else if (index == 5)
                return location;
            return null;
        }
        set
        {
            if(index == 1)
                eno=(int)value;
            else if (index == 2)
                salary=(double)value;
            else if (index == 3)
                fname=(string)value;
            else if (index == 4)
                dname=(string)value;
            else if(index == 5)
                location=(string)value;
        }
    }
}
