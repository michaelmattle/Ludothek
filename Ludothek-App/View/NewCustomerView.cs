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
            Customer newCustomer = new Customer
            {
                Name = txtName.Text,
                Surename = txtSurename.Text,
                Phone = txtPhoneNo.Text,
                Birthday = dateBirthday.SelectionRange.Start.ToString(),
                Street = txtStreet.Text,
                ZIP = txtZIP.Text,
                Place = txtPlace.Text,
                Country = txtCountry.Text,
                EMail = txtMail.Text,
                ClubMember = cbClubMember.Checked
            };

            _controller.AddCustomer(newCustomer);
           
        }

        private void NewCustomerView_Load(object sender, EventArgs e)
        {
            _model.AddView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }
    }
}