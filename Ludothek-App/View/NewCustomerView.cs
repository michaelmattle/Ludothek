using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class NewCustomerView : Form, IView
    {
        CustomerModel _model;
        CustomerController _controller;

        public NewCustomerView(CustomerModel model)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            dateBirthday.MaxSelectionCount = 1;

            _model = model;
            _controller = new CustomerController(_model, this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurename.Text != "" && txtCountry.Text != "" && txtPlace.Text != "" && 
                txtStreet.Text != "" && txtZIP.Text != "" && txtPhoneNo.Text != "" && txtMail.Text != "")
            {
                Customer newCustomer = new Customer(txtName.Text, txtSurename.Text, txtPhoneNo.Text, dateBirthday.SelectionRange.Start.ToString(),
                txtStreet.Text, txtZIP.Text, txtPlace.Text, txtCountry.Text, txtMail.Text, cbClubMember.Checked,
                _controller.getNoOfCustomers() + 1);

                _controller.AddCustomer(newCustomer);
                _model.UpdateAllViews();
                resetTextFields();
            }
        }

        private void NewCustomerView_Load(object sender, EventArgs e)
        {
            _model.AddView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }

        public void resetTextFields()
        {
            txtName.Text = "";
            txtSurename.Text = "";
            txtPhoneNo.Text = "";
            txtStreet.Text = "";
            txtZIP.Text = "";
            txtPlace.Text = "";
            txtCountry.Text = "";
            txtMail.Text = "";
            cbClubMember.Checked = false;
        }
    }
}