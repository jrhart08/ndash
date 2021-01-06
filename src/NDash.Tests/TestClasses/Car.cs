using System;
using System.Collections.Generic;
using System.Text;

namespace NDash.Tests.TestClasses
{
    class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
