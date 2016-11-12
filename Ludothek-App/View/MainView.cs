using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class MainView : Form, IView
    {
        private readonly Repository _repo;
        private MainModel _model;
        private MainController _controller;

        public MainView(Repository repository)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            _repo = repository;
            _model = new MainModel();
            _controller = new MainController(_model, this, listDueReturns);
        }
        
        private void btnRentToy_Click(object sender, EventArgs e)
        {
            RentToyView rentToyView = new RentToyView();
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
            ToyModel model = new ToyModel();
            ToysListView toyListView = new ToysListView(model);
            toyListView.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel();
            CustomerListView clv = new CustomerListView(model);
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
            ToyModel model = new ToyModel();
            ToysListView toyListView = new ToysListView(model);
            toyListView.ShowDialog();
        }

        private void übersichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerListView clv = new CustomerListView(new CustomerModel());
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
