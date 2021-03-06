﻿using Ludothek.Application.Controller;
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
        ToyController _controller;

        public ToysListView(Model.ToyModel toymodel)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _model = toymodel;
            _controller = new Controller.ToyController(_model, this, listAllToys);
        }

        // update selected toy data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listAllToys.SelectedIndices[0];
                Toy selectedToy = _model.GetToyById(selectedIndex + 1);
                Toy newToy = new Toy(txtToyName.Text, combCategory.Text, txtBrand.Text, Convert.ToDouble(txtPricePerWeek.Text), selectedToy.Available, selectedToy.ToyNo);
                _controller.ChangeToy(selectedToy, newToy);
            }
            catch (Exception ex) { }
        }

        private void btnNewToy_Click(object sender, EventArgs e)
        {
            NewToyView ntv = new NewToyView(_model);
            ntv.ShowDialog();
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

        private void listAllToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listAllToys.SelectedIndices[0];
                Toy selectedToy = _model.GetToyById(selectedIndex + 1);

                // fill form fields
                txtToyNo.Text = selectedToy.ToyNo + "";
                txtToyName.Text = selectedToy.Name;
                txtBrand.Text = selectedToy.Brand;
                combCategory.Text = selectedToy.Category;
                txtPricePerWeek.Text = selectedToy.PricePerWeek.ToString();

                if (selectedToy.Available == false)
                {
                    txtToyName.ReadOnly = true;
                    txtBrand.ReadOnly = true;
                    txtPricePerWeek.ReadOnly = true;
                    btnAccept.Enabled = false;
                }
                else
                {
                    txtToyName.ReadOnly = false;
                    txtBrand.ReadOnly = false;
                    txtPricePerWeek.ReadOnly = false;
                    btnAccept.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // do stuff with exception
            }
        }
        
    }
}
