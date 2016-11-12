using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class ToysView : Form, IView
    {
        Model.ToyModel _model;
        Controller.ToyController _controller;

        public ToysView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            _model = toymodel;
            _controller = new Controller.ToyController(_model, this );
            _model.AddView(this);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateView()
        {
            _controller.Update();
        }
    }
}
