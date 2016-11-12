using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class MainView : Form
    {
        private readonly Repository _repo;
        private BaseController _controller;

        public MainView(Repository repository)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            _repo = repository;
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
            CustomerListView clv = new CustomerListView(new CustomerModel());
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
            CustomerListView clv = new CustomerListView(new CustomerModel());
            clv.ShowDialog();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _
        }
    }
}
