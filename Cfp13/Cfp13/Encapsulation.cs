using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public  class Encapsulation
    {
        private int _id;
        private string _name;
        private string _role;

        public Encapsulation(int id, string name, string role)
        {
            _id = id;
            _name = name;
            _role = role;
        }

        public int id
        {
            get { return _id; }
        }
        public string name 
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string role 
        { 
            get { return _role; } 
            set {  _role = value; }
        }
       
    }
}
