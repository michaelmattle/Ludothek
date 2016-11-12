using Ludothek.Application.Model;
using System.Windows.Forms;
using System;

namespace Ludothek.Application.Controller
{
    class ToysViewController : BaseController
    {
        Model.ToyModel model;
        View.ToysView view;
        ListBox listBox;

        public ToysViewController(Model.ToyModel model, View.ToysView view, ListBox listBox)
        {   
            this.model = model;
            this.view = view;
            this.listBox = listBox;
            listBox.DisplayMember = nameof(Toy.Name);
        }

        public void UpdateView()
        {
            listBox.Items.Clear();
            foreach (Toy toy in model)
            {
                listBox.Items.Add(toy);
            }
        }

        public void Sort(bool isSorted)
        {
            listBox.Sorted = isSorted;
            //no change in model, but update all views
            model.UpdateAllViews();
        }

        public void RemoveSelectedPerson()
        {
            Toy toy = listBox.SelectedItem as Toy;
            if (toy != null)
                model.RemoveToy(toy);
        }

        public void ChangeSelectedPerson(Toy newToy)
        {
            Toy toy = listBox.SelectedItem as Toy;
            if (toy != null)
                model.ChangePerson(toy, newToy);
        }

        public void SelectionChanged()
        {
            Toy toy = listBox.SelectedItem as Toy;
            if (toy != null)
            {
                //selected Item
            }
        }

        public void Update()
        {
            /*
            listView.Items.Clear();
            foreach (Toy toy in model)
            {
                ListViewItem item = new ListViewItem(toy.Name);
                item.SubItems.Add(toy.Brand);
                item.SubItems.Add(toy.Category);
                item.SubItems.Add(toy.PricePerWeek.ToString());
                listView.Items.Add(item);
            }
            */
        }

    }
}
