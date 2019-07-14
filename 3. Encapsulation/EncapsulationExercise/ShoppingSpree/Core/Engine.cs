using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ShoppingSpree.Model;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> persons;

        private List<Product> products;

        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                AddPersons();
                AddProducts();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }            

            string inputNames = string.Empty;

            while ((inputNames = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = inputNames
                        .Split()
                        .ToArray();

                    string name = tokens[0];
                    string productType = tokens[1];

                    Person person = persons.FirstOrDefault(p => p.Name == name);
                    Product product = products.FirstOrDefault(p => p.Name == productType);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var eachPerson in persons)
            {
                Console.WriteLine(eachPerson.ToString());
            }
        }

        private void AddProducts()
        {
            var inputProducts = Console.ReadLine()
                            .Split(";", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            foreach (var eachPerson in inputProducts)
            {
                var personTokens = eachPerson
                    .Split("=")
                    .ToArray();

                string name = personTokens[0];
                decimal cost = decimal.Parse(personTokens[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }
        }

        private void AddPersons()
        {
            var inputPersons = Console.ReadLine()
                            .Split(";", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            foreach (var eachPerson in inputPersons)
            {
                var personTokens = eachPerson
                    .Split("=")
                    .ToArray();

                string name = personTokens[0];
                decimal money = decimal.Parse(personTokens[1]);

                Person person = new Person(name, money);
                persons.Add(person);
            }
        }
    }
}
