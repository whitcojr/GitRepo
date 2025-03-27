using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitRepo
{
    internal class Apple
    {

        private string _color;
        private double _price;
        private string _weight;

        // Create getter and a setter for the private properties
        public double Price { get { return _price; } set { _price = value; } }
        public string Color { get { return _color; } set { _color = value; } }

        public string Weight { get { return _weight; } set { _weight = value; } }
    }
}
