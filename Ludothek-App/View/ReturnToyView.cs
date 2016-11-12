using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class ReturnToyView : Form
    {
        Model.ToyModel _model;
        public ReturnToyView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = toymodel;
        }

        private void btnToys_Click(object sender, EventArgs e)
        {
            ToysView tv = new ToysView(_model);
            var result = tv.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
