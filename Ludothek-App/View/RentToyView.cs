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
            using (CustomersView view = new CustomersView(customerModel))
            {
                var result = view.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //values preserved after close
                    Customer selectedCustomer = view.SelectedCustomer;

                    txtCustomerNo.Text = selectedCustomer.CustomerNo +"";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            toyModel.RemoveView(this);
            Close();
        }
     
        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        public void UpdateView()
        {
            // todo fix
        }

        private void RentToyView_Load(object sender, EventArgs e)
        {
            toyModel.AddView(this);
        }
    }
}
