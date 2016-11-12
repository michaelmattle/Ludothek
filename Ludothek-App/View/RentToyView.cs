using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class RentToyView : Form, IView
    {
        private CustomerModel customerModel;
        private ToyModel toyModel;

        public RentToyView(CustomerModel customerModel, ToyModel toyModel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            this.customerModel = customerModel;
            this.toyModel = toyModel;
        }

        private void btnToys_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersView view = new CustomersView(customerModel);
            view.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
     
        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
