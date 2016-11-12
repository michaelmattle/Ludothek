﻿using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class CustomersController : BaseController
    {
        CustomerModel model;
        CustomersView view;
        ListView listView;

        public CustomersController(CustomerModel model, CustomersView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public void Update()
        {
            listView.Items.Clear();
            foreach (Customer customer in model)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.Surename);
                item.SubItems.Add(customer.Name);
                listView.Items.Add(item);
            }
        }
    }
}
