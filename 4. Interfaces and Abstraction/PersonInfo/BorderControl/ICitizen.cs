using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface ICitizen
    {
        string Name { get; set; }

        int Age { get; set; }

        long Id { get; set; }

        DateTime Birthday { get; set; }
    }
}
