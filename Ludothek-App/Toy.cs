using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Model
{
    public class Toy
    {
        public int ToyNo;
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public double PricePerWeek { get; set; }

        public Toy(string name, string category, string brand, double priceperweek)
        {
            Name = name;
            Category = category;
            Brand = brand;
            PricePerWeek = priceperweek;
        }
    }
}
