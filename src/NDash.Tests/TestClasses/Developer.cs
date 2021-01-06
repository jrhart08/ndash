using System;
using System.Collections.Generic;
using System.Text;

namespace NDash.Tests.TestClasses
{
    class Developer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Developer(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

}
