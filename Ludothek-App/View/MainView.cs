using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class MainView : Form, IView
    {
        private MainModel _model;
        private MainController _controller;
        ToyModel toyModel;
        CustomerModel customerModel;

        public MainView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            _model = new MainModel();
            _controller = new MainController(_model, this, listDueReturns);
            toyModel = new ToyModel();
            customerModel = new CustomerModel();
        }
        
        private void btnRentToy_Click(object sender, EventArgs e)
        {
            RentToyView rtv = new RentToyView(customerModel, toyModel);
            rtv.ShowDialog();
        }

        private void btnReturnToy_Click(object sender, EventArgs e)
        {
            ReturnToyView returnTV = new ReturnToyView();
            returnTV.ShowDialog();
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            ToysListView toyListView = new ToysListView(toyModel);
            toyListView.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerListView clv = new CustomerListView(customerModel);
            clv.ShowDialog();
        }

        private void btnProlong_Click(object sender, EventArgs e)
        {

        }
        
        private void ausleihenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentToyView rtv = new RentToyView(customerModel, toyModel);
            rtv.ShowDialog();
        }

        private void zurückgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnToyView returnTV = new ReturnToyView();
            returnTV.ShowDialog();
        }

        private void übersichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToysListView toyListView = new ToysListView(toyModel);
            toyListView.ShowDialog();
        }

        private void übersichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerListView clv = new CustomerListView(customerModel);
            clv.ShowDialog();
        }

        #region Observer
        private void MainView_Load(object sender, EventArgs e)
        {
            // register observer
            _model.AddView(this);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            _model.RemoveView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }
        #endregion
    }
}
