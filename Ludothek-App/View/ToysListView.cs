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
    public partial class ToysListView : Form, IView
    {
        Model.ToyModel model;
        Controller.ToyListViewController controller;

        public ToysListView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            model = toymodel;
            controller = new Controller.ToyListViewController(model, this, listAllToys);
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

        #region Observer
        private void ToyListView_Load(object sender, EventArgs e)
        {
            //register observer
            model.AddView(this);
        }

        private void PersonenListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //deregister observer
            model.RemoveView(this);
        }

        public void UpdateView()
        {
            controller.update();
        }
        #endregion
    }
}
