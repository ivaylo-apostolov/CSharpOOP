using System;
using System.Collections.Generic;
using System.Text;

namespace temp
{
    public class Human : Person
    {
        public override void Mammal()
        {
            base.Mammal();
            _ = Environment.NewLine;
            Console.WriteLine("also Human");               
        }

        public override void Creature()
        {
            base.Creature();
            _ = Environment.NewLine;
            Console.WriteLine("also Human");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("Add int a, int b");
        }
    }
}
