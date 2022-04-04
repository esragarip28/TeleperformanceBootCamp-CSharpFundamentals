using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClassInitializer
{
    internal class Car
    {
        public Car() { }
        public Car(string model) { this.Model = model; }
        public string Brand { get; set; }//property
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }

    }
}
