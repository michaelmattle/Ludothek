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

        public CustomerListView(CustomerModel model)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = model;
            _controller = new CustomerController(_model, this, listAllCustomers);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerView ncv = new NewCustomerView(this);
            ncv.ShowDialog();
        }
       
        #region Observer
        private void CustomerListView_Load(object sender, EventArgs e)
        {
            //register observer
            _model.AddView(this);
        }

        private void CustomerListView_FormClosing(object sender, FormClosingEventArgs e)
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
