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

            model.AddDueRental(new Rental(new Toy("adf", "asdf", "adf", 33.3), new Customer("dasdf", "asfd", "asdf", "asdfadf", "asdfasdf", "asdfad", "asdfasdf", "asdfasdf", "asdfasdf", false, 123)));
            foreach (Rental due in model)
            {
                ListViewItem item = new ListViewItem(due.Toy.Name);
                item.SubItems.Add(due.Customer.Name);
                listView.Items.Add(item);
            }
            
        }
    }
}
