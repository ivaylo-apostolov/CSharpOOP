using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citi : ICitizen, IRobot, IPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long Id { get; set; }
        public string Model { get; set; }
        public DateTime Birthday { get; set; }

        public Citi(string name, int age, long id, DateTime birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public Citi(string model, long id)
        {
            this.Model = model;
            this.Id = id;
        }

        public Citi(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }


    }
}
