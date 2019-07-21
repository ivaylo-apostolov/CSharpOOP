using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        int Age { get; }

        string GetName();
    }
}
