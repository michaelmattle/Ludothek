using Ludothek.Application.Controller;
using Ludothek.Application.Model;
using System;
using System.Windows.Forms;

namespace Ludothek.Application.View
{
    public partial class NewToyView : Form, IView
    {
        ToyModel _model;
        ToyController _controller;

        public NewToyView(ToyModel model)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = model;
            _controller = new ToyController(_model, this);
        }
        
        private void NewToyView_Load(object sender, EventArgs e)
        {
            _model.AddView(this);
        }

        public void UpdateView()
        {
            _controller.Update();
        }

        public void resetTextFields()
        {
            txtToyName.Text = "";
            txtPricePerWeek.Text = "";
            txtBrand.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //use second constructor with id = List.count + 1
            if (txtToyName.Text != "" && txtPricePerWeek.Text != "" && txtBrand.Text != "" && combCategory.Text != "")
            {
                double pricePerWeek = Convert.ToDouble(txtPricePerWeek.Text);
                Toy newToy = new Toy(txtToyName.Text, combCategory.Text, txtBrand.Text, pricePerWeek, true, _controller.getNoOfToys() + 1);
                    
                _controller.AddToy(newToy);
                _model.UpdateAllViews();
                resetTextFields();
            }
        }
    }
}
