using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application
{
    class Rental
    { 
        public Toy Toy { get; set; }
        public Customer Customer { get; set; }

        public Rental(Toy toy, Customer customer)
        {
            Customer = customer;
            Toy = toy;
        }
    }
}
