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

            foreach (Toy toy in model)
            {
                ListViewItem item = new ListViewItem(toy.Name);
                item.SubItems.Add(toy.CustomerNumber);
                item.SubItems.Add(DateTime.Today.AddDays(7.0));
                listView.Items.Add(item);
            }
        }
    }
}
