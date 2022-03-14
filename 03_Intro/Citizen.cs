using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intro
{
    internal class Citizen
    {
        public string _name;
        public string _nationalIdentity;

        //default constructor.
        public Citizen() { }
        public Citizen(string name,string nationalIdentity)
        {
            _name = name;
            _nationalIdentity = nationalIdentity;
        }
        //ctor+tab+tab : shortcut to create constructor.

    }
}
