using System;
using Ludothek.Application.Model;
using Ludothek.Application.View;
using System.Windows.Forms;

namespace Ludothek.Application.Controller
{
    class ToyController : BaseController
    {
        ToyModel model;
        IView view;
        ListView listView;

        public ToyController(ToyModel model, IView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public ToyController(ToyModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddToy(Toy toy)
        {
            model.AddToy(toy);
        }


        public void Update()
        {
            if (listView != null)
            {
                listView.Items.Clear();
                foreach (Toy toy in model)
                {
                    ListViewItem item = new ListViewItem(toy.Name);
                    item.SubItems.Add(toy.Brand);
                    item.SubItems.Add(toy.Category);
                    item.SubItems.Add(toy.PricePerWeek.ToString());
                    listView.Items.Add(item);
                }
            }
        }

        public int getNoOfToys()
        {
            int counter = 0;
            foreach (Toy toy in model)
            {
                counter++;
            }

            return counter;
        }
    }
}
