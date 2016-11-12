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
    public partial class ToysListView : Form
    {
        Model.ToyModel model;
        Controller.ToyController controller;

        public ToysListView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            model = toymodel;
            controller = new Controller.ToyController(model, this, listAllToys);
        }

        public ToysListView()
        {
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnNewToy_Click(object sender, EventArgs e)
        {

        }
    }
}
