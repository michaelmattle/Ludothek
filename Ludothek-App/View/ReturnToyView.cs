using System;
using System.Windows.Forms;
using Ludothek.Application.Model;

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
            using (ToysView view = new ToysView(_model))
            {
                ToysView tv = new ToysView(_model);
                var result = tv.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //values preserved after close
                    Toy selectedToy = view.SelectedToy;
                    txtToyNo.Text = selectedToy.ToyNo + "";
                }
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
