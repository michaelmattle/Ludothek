using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class CustomerController : BaseController
    {
        CustomerModel model;
        IView view;
        ListView listView;

        public CustomerController(CustomerModel model, IView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public CustomerController(CustomerModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddCustomer(Customer customer)
        {
            model.AddCustomer(customer);
        }
        

        public void Update()
        {
            if(listView != null)
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
}
