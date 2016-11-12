using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludothek.Application.Model
{
    public class Customer
    {
        public int CustomerNo;
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Street { get; set; }
        public string ZIP { get; set; }
        public string Place { get; set; }
        public string Country { get; set; }
        public string EMail { get; set; }
        public bool ClubMember { get; set; }

        public Customer(string name, string surename, string phone, string birthday, string street, string zip, string place, string country, string email, bool clubmember, int customerno)
        {
            Name = name;
            Surename = surename;
            Phone = phone;
            Birthday = birthday;
            Street = street;
            ZIP = zip;
            Place = place;
            Country = country;
            EMail = email;
            ClubMember = clubmember;
            CustomerNo = customerno;
        }
    }
}
