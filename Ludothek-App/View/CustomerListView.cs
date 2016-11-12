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
    public partial class CustomerListView : Form
    {
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
    }
}
