using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreature creature = new Human();
            IMammal mammal = new Human();
            Person person = new Human();
            Human human = new Human();

            
            person.Mammal();

            person.Add(1);
            human.Add(1, 2);


        }
    }
}
