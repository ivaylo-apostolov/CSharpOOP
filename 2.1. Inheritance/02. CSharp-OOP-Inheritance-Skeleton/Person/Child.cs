using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            :base(name, age)
        {
            if (this.Age <= 15)
            {
                this.Age = age;
            }
            else
            {
                throw new ArgumentException("Children should not be able to have an age more than 15");
            }
        }              
    }
}
