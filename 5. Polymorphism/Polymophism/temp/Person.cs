using System;
using System.Collections.Generic;
using System.Text;

namespace temp
{
    public class Person : IMammal, ICreature
    {
        public virtual void Creature()
        {
            Console.WriteLine("I am a creature");
        }

        public virtual void Mammal()
        {
            Console.WriteLine("I am a mammal");
        }

        public void Add(int a)
        {
            Console.WriteLine("Add int a");
        }
    }
}
