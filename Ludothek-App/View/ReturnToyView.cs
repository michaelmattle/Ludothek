using System;
using System.Windows.Forms;
using Ludothek.Application.Model;

namespace Ludothek.Application.View
{
    public partial class ReturnToyView : Form
    {
        private Toy selectedToy;
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
                var result = view.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //values preserved after close
                    selectedToy = view.SelectedToy;
                    selectedToy.Available = true;
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
            if (selectedToy != null)
            {
                selectedToy.Available = true;
            }
            Close();
        }
    }
}
