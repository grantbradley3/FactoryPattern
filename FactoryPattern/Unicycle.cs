﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Unicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new unicycle for your circus!");
        }
    }
}
