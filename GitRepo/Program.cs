﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple myApple = new Apple(); // Declare and instantiate
            myApple.Price = 2.25; // Invoke the setter
            Console.WriteLine("Price of my apple is " + myApple.Price); // getter
            myApple.Color = "red";
            Console.WriteLine("Color of my apple is " + myApple.Color);
            myApple.Weight = "150"; 
            Console.WriteLine("Weight of my apple is " + myApple.Weight + "g"); // getter
            Console.WriteLine("Andrew and Jeff");

        }
    }
}
