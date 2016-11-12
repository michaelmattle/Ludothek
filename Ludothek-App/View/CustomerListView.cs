using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class CustomerListView : Form, IView
    {
        CustomerModel _model;
        CustomerController _controller;

        MainView MV;
        public CustomerListView(MainView mv)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MV = mv;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerView ncv = new NewCustomerView(MV);
            ncv.ShowDialog();
        }
        PersonenModel personenModel;
        PersonenListViewController personelListViewController;

        public PersonenListView(PersonenModel model)
        {
            InitializeComponent();
            personenModel = model;
            personelListViewController = new PersonenListViewController(personenModel, this, listAllCustomers);
        }


        #region Observer
        private void PersonenListView_Load(object sender, EventArgs e)
        {
            //register observer
            personenModel.AddView(this);
        }

        private void PersonenListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            personenModel.RemoveView(this);
        }

        public void UpdateView()
        {
            personelListViewController.update();
        }
        #endregion
    }
}
