﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IRobot
    {
        string Model { get; set; }

        long Id { get; set; }
    }
}
