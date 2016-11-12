using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class MainController : BaseController
    {
        MainModel model;
        MainView view;
        ListView listView;

        public MainController(MainModel model, MainView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public void Update()
        {

            listView.Items.Clear();

            ListViewItem item = new ListViewItem("adsf");
            item.SubItems.Add("hello");
            item.SubItems.Add("dario");
            listView.Items.Add(item);
            /*
            foreach (Custom in model)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.Surename);
                item.SubItems.Add(customer.Phone);
                listView.Items.Add(item);
            }

            add returns to model

            */
        }
    }
}
