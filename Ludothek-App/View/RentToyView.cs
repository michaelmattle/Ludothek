using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class RentToyView : Form, IView
    {
        private CustomerModel customerModel;
        private ToyModel toyModel;
        private Toy SelectedToy;
        private Customer SelectedCustomer;

        public RentToyView(CustomerModel customerModel, ToyModel toyModel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            this.customerModel = customerModel;
            this.toyModel = toyModel;
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            using (ToysView view = new ToysView(toyModel))
            {
                var result = view.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //values preserved after close
                    this.SelectedToy = view.SelectedToy;

                    txtToyNo.Text = this.SelectedToy.ToyNo + "";


                    lblPricePerWeek.Text = this.SelectedToy.PricePerWeek + "";
                }
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (CustomersView view = new CustomersView(customerModel))
            {
                var result = view.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //values preserved after close
                    this.SelectedCustomer = view.SelectedCustomer;

                    txtCustomerNo.Text = this.SelectedCustomer.CustomerNo +"";
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
            if(SelectedToy != null && SelectedCustomer != null)
            {
                var toy = toyModel.GetToyById(SelectedToy.ToyNo);
                SelectedToy.Available = false;
                SelectedToy.CustomerNumber = SelectedCustomer.CustomerNo;
                toyModel.ChangeToy(toy, SelectedToy);

                clearFields();
            }
        }

        public void UpdateView()
        {
            // todo fix
        }

        private void clearFields()
        {
            txtCustomerNo.Text = "";
            txtToyNo.Text = "";

            SelectedToy = null;
            SelectedCustomer = null;
        }

        private void RentToyView_Load(object sender, EventArgs e)
        {
            toyModel.AddView(this);
        }
    }
}
