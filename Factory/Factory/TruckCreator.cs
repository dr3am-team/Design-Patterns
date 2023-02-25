﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class TruckCreator : Creator
    {
        public override Product CreateTransport()
        {
            return new Truck();
        }
    }
}
