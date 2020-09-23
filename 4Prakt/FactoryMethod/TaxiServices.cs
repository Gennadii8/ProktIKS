﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TaxiServices : TransportService
    {
        public int Category { get; set; }

        public TaxiServices(string name, int cat): base (name)
        {
            Category = cat;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }

        public override string ToString()
        {
            string s = String.Format("Firm {0}, the category of a ride {1}", Name, Category);
            return s;
        }
    }
}
