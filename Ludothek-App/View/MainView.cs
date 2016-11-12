using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class MainView : Form
    {
        List<Customer> Customers;
        List<Toy> Toys;

        public MainView()
        {
            Customers = new List<Customer>(0);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnRentToy_Click(object sender, EventArgs e)
        {
            RentToyView rtv = new RentToyView();
            rtv.ShowDialog();
        }

        private void btnReturnToy_Click(object sender, EventArgs e)
        {
            ReturnToyView returnTV = new ReturnToyView();
            returnTV.ShowDialog();
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            ToysListView tlv = new ToysListView();
            tlv.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerListView clv = new CustomerListView(this);
            clv.ShowDialog();
        }

        private void btnProlong_Click(object sender, EventArgs e)
        {

        }

        private void ausleihenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentToyView rtv = new RentToyView();
            rtv.ShowDialog();
        }

        private void zurückgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnToyView returnTV = new ReturnToyView();
            returnTV.ShowDialog();
        }

        private void übersichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToysListView tlv = new ToysListView();
            tlv.ShowDialog();
        }

        private void übersichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerListView clv = new CustomerListView(this);
            clv.ShowDialog();
        }

        public void addCustomer(string name, string surename, string phone, string birthday, string street, string zip, string place, string country, string email, bool clubmember)
        {
            Customer customer = new Customer(name, surename, phone, birthday, street, zip, place, country, email, clubmember, 1);
            Customers.Add(customer);
        }

        public List<List<string>> getCustomer()
        {
            List<List<string>> CustomersAsStringList = new List<List<string>>(Customers.Count);
            int Counter = 0;

            foreach (var Customer in Customers)
            {
                CustomersAsStringList[Counter].Add(Customer.CustomerNo.ToString());
                CustomersAsStringList[Counter].Add(Customer.Name);
                CustomersAsStringList[Counter].Add(Customer.Surename);
                CustomersAsStringList[Counter].Add(Customer.Phone);
                CustomersAsStringList[Counter].Add(Customer.Birthday);
                CustomersAsStringList[Counter].Add(Customer.Street);
                CustomersAsStringList[Counter].Add(Customer.ZIP);
                CustomersAsStringList[Counter].Add(Customer.Place);
                CustomersAsStringList[Counter].Add(Customer.Country);
                CustomersAsStringList[Counter].Add(Customer.EMail);
                CustomersAsStringList[Counter].Add(Customer.ClubMember.ToString());
                Counter++;
            }

            return CustomersAsStringList;
        }
    }
}
