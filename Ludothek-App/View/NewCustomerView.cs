using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class NewCustomerView : Form
    {
        private CustomerListView customerListView;

        public NewCustomerView(CustomerListView customerListView)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            dateBirthday.MaxSelectionCount = 1;
            this.customerListView = customerListView;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Surename = txtSurename.Text;
            string Phone = txtPhoneNo.Text;
            string Birthday = dateBirthday.SelectionRange.Start.ToString();
            string Street = txtStreet.Text;
            string ZIP = txtZIP.Text;
            string Place = txtPlace.Text;
            string Country = txtCountry.Text;
            string EMail = txtMail.Text;
            bool ClubMember = cbClubMember.Checked;

        }
    }
}