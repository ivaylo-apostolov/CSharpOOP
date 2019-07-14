using ShoppingSpree.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Model
{
    public class Person
    {
        private string name;

        private decimal money;

        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessage.NameCannotBeEmpty);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessage.MoneyCannotBeNegative);
                }

                this.money = value;
            }
        }


        public void BuyProduct(Product product)
        {
            if (product.Cost <= this.Money)
            {
                this.Money -= product.Cost;
                products.Add(product);
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
            else
            {
                throw new InvalidOperationException(String.Format(
                    ExeptionMessage.PersonCannotAffordProduct,
                    this.Name, product.Name));
            }
        }

        public override string ToString()
        {
            if (this.products.Count > 0)
            {
                return $"{this.name} - {String.Join(", ", products)}";
            }            

            return $"{this.Name} - Nothing bought ";
        }
    }
}
