using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class CustomersView : Form, IView
    {
        CustomerModel _model;
        CustomerController _controller;

        public Customer SelectedCustomer { get; set; }

        public CustomersView(CustomerModel model)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = model;
            _controller = new CustomerController(_model, this, listAllCustomers);
            _model.AddView(this);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Close();
=======
            if(this.SelectedCustomer != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
>>>>>>> origin/master
        }
        
        #region Observer
        private void CustomersView_Load(object sender, EventArgs e)
        {
            //register observer
            _model.AddView(this);
        }
        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            _model.RemoveView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }
        #endregion

        private void listAllCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listAllCustomers.SelectedIndices[0];

                Customer selectedCustomer = _model.GetCustomerById(selectedIndex + 1);

                this.SelectedCustomer = selectedCustomer;
            }
            catch (Exception ex) {}
        }
    }
}
