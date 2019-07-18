using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Model.Animal.Bird;
using WildFarm.Model.Animal.Mammal;
using WildFarm.Model.Animal.Mammal.Feline;

namespace WildFarm.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string input = string.Empty;
            int n = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                if (n == 2)
                {
                    n = 0;
                }

                var tokens = input
                    .Split();

                if (n == 0)
                {
                    string type = tokens[0];
                    string name = tokens[1];
                    double weight = double.Parse(tokens[2]);

                    if (type == "Cat")
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];

                        Feline cat = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (type == "Tiger")
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];

                        Feline tiger = new Tiger(name, weight, livingRegion, breed);
                    }
                    else if (type == "Owl")
                    {
                        double wingSize = double.Parse(tokens[3]);

                        Bird owl = new Owl(name, weight, wingSize);
                    }
                    else if (type == "Hen")
                    {
                        double wingSize = double.Parse(tokens[3]);

                        Bird owl = new Hen(name, weight, wingSize);
                    }
                    else if (type == "Mouse")
                    {
                        string livingRegion = tokens[3];

                        Mammal mouse = new Mouse(name, weight, livingRegion);
                    }
                    else if (type == "Dog")
                    {
                        string livingRegion = tokens[3];

                        Mammal dog = new Dog(name, weight, livingRegion);
                    }

                }
                else if (n == 1)
                {
                    string type = tokens[0];
                    int piece = int.Parse(tokens[1]);

                    if (type )
                    {

                    }
                }

                n++;
            }
        }
    }
}
