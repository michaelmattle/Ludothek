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
            _model.AddView(this);

        }

        // update selected customer data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerView ncv = new NewCustomerView(_model);
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

        private void listAllCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listAllCustomers.SelectedIndices[0];
                
                Customer selectedCustomer = _model.GetCustomerById(selectedIndex + 1);

                // fill form fields
                txtCustomerNo.Text = selectedCustomer.CustomerNo  + "";
                txtName.Text = selectedCustomer.Name;
                txtSurename.Text = selectedCustomer.Surename;
                txtMail.Text = selectedCustomer.EMail;
                dateBirthday.SetDate(Convert.ToDateTime(selectedCustomer.Birthday));
                txtStreet.Text = selectedCustomer.Street;
                txtZIP.Text = selectedCustomer.ZIP;
                txtPlace.Text = selectedCustomer.Place;
                txtCountry.Text = selectedCustomer.Country;
                txtCountry.Text = selectedCustomer.Country;
                txtPhoneNo.Text = selectedCustomer.Phone;
                cbClubMember.Checked = selectedCustomer.ClubMember;
                
            }
            catch (Exception ex)
            {
                // do stuff with exception
            }


        }
    }
}
