using Ludothek.Application.Controller;
using Ludothek.Application.Model;
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
        ToyModel _model;
        ToyListViewController _controller;

        public ToysListView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = toymodel;
            _controller = new Controller.ToyListViewController(_model, this, listAllToys);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnNewToy_Click(object sender, EventArgs e)
        {

        }

        #region Observer
        private void ToysListView_Load(object sender, EventArgs e)
        {
            // register observer
           _model.AddView(this);
        }

        private void PersonenListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // deregister observer
            _model.RemoveView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }
        #endregion

    }
}
