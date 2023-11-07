// See https://aka.ms/new-console-template for more information
using properties1;
using System;
class Customer
{
    int _custid;
    bool _status;
    string _cname;
    double _balance;
    Cities _city;
    public Customer(int custid, bool status, string cname, double balance, Cities city)
    {
        _custid = custid;
        _status = status;
        _cname = cname;
        _balance = balance;
        _city = city;                   //enum cities
    }
    public int custid
    {
        get { return _custid; }           //only getting value not able to assign a value becuse there is no set property
    }
    public bool status
    {
        get { return _status;}            //here both get and set values are assigned
        set { _status = value;}
    }
    public string cname
    {
        get { return _cname; }
        set {
            if(_status==true )
            _cname = value; }
    }
    public double balance
    {
        get { return _balance; }   
        set { 
            if(_status==true )
            _balance = value;}
    }
    public Cities city
    {
        get { return _city; }
        set
        {
            if(_status==true )
                _city = value;
        }
    }
}