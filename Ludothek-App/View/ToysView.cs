using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class ToysView : Form, IView
    {
        public int selectedToyID;
        Model.ToyModel _model;
        Controller.ToyController _controller;

        public ToysView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = toymodel;
            _controller = new Controller.ToyController(_model, this, listAllToys);
            _model.AddView(this);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Observer
        private void ToysView_Load(object sender, EventArgs e)
        {
            //register observer
            _model.AddView(this);
        }
        private void ToysView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            _model.RemoveView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }
        #endregion

        private void listAllToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedToyID = listAllToys.SelectedIndices[0] + 1;
            }
            catch (Exception ex)
            {
                // do stuff with exception
            }
        }
    }
}
