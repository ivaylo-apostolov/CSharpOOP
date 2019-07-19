using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Model.Animal;
using WildFarm.Model.Animal.Bird;
using WildFarm.Model.Animal.Mammal;
using WildFarm.Model.Animal.Mammal.Feline;
using WildFarm.Model.Food;

namespace WildFarm.Core
{
    public class Engine
    {
        Animal animal = null;
        Food food = null;

        private List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
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
                    animal = null;
                    food = null;
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

                        if (cat is Animal)
                        {
                            animal = cat;
                        }
                    }
                    else if (type == "Tiger")
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];

                        Feline tiger = new Tiger(name, weight, livingRegion, breed);

                        if (tiger is Animal)
                        {
                            animal = tiger;
                        }
                    }
                    else if (type == "Owl")
                    {
                        double wingSize = double.Parse(tokens[3]);

                        Bird owl = new Owl(name, weight, wingSize);

                        if (owl is Animal)
                        {
                            animal = owl;
                        }
                    }
                    else if (type == "Hen")
                    {
                        double wingSize = double.Parse(tokens[3]);

                        Bird hen = new Hen(name, weight, wingSize);

                        if (hen is Animal)
                        {
                            animal = hen;
                        }
                    }
                    else if (type == "Mouse")
                    {
                        string livingRegion = tokens[3];

                        Mammal mouse = new Mouse(name, weight, livingRegion);

                        if (mouse is Animal)
                        {
                            animal = mouse;
                        }
                    }
                    else if (type == "Dog")
                    {
                        string livingRegion = tokens[3];

                        Mammal dog = new Dog(name, weight, livingRegion);

                        if (dog is Animal)
                        {
                            animal = dog;
                        }
                    }

                }
                else if (n == 1)
                {
                    string type = tokens[0];
                    int quantity = int.Parse(tokens[1]);

                    if (type == "Vegetable")
                    {
                        Food vegetable = new Vegetable(quantity);

                        if (vegetable is Food)
                        {
                            food = vegetable;
                        }
                    }
                    else if (type == "Fruit")
                    {
                        Food fruit = new Fruit(quantity);

                        if (fruit is Food)
                        {
                            food = fruit;
                        }
                    }
                    else if (type == "Meat")
                    {
                        Food meat = new Meat(quantity);

                        if (meat is Food)
                        {
                            food = meat;
                        }
                    }
                    else if (type == "Seeds")
                    {
                        Food seeds = new Seeds(quantity);

                        if (seeds is Food)
                        {
                            food = seeds;
                        }
                    }
                }

                n++;

                if (n == 2)
                {

                    Console.WriteLine(animal.ProduceSound());

                    try
                    {
                        animal.Eating(food);
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }

                    animals.Add(animal);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
