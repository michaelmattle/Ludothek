using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class CustomerController : BaseController
    {
        CustomerModel model;
        CustomerListView view;
        ListView listView;

        public CustomerController(CustomerModel model, CustomerListView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public CustomerController()
        {
        }

        public void Update()
        {
            listView.Items.Clear();
            foreach (Customer customer in model)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.Surename);
                item.SubItems.Add(customer.Phone);
                listView.Items.Add(item);
            }
        }
    }
}
