using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface iCar
    {
        string Model { get; set; }

        string DriverName { get; set; }

        string Break();

        string Gas();
    }
}
