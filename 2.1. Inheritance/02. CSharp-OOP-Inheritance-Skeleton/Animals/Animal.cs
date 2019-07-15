using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (this.Age >= 0)
                {
                    this.Age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public string Gender
        {
            get
            {
                return this.Gender;
            }
            set
            {
                if (this.Gender == "Tomcat")
                {
                    this.Gender = "Male";
                }
                else if (this.Gender == "Kitten")
                {
                    this.Gender = "Female";
                }
                if (this.Gender == "Male" || this.Gender == "Female")
                {
                    this.Gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public virtual string ProduceSound()
        {
            return "Animal";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"")

            return base.ToString();
        }
    }
}
