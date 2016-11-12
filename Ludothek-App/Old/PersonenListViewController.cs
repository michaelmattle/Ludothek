using System.Windows.Forms;

namespace PersonenverwaltungMVC_2
{
    class PersonenListViewController
    {
        PersonenModel model;
        PersonenListView view;
        ListView  listView;

        public PersonenListViewController(PersonenModel model, PersonenListView view, ListView listView)
        {
            this.model = model;
            this.view = view;
            this.listView = listView;
        }

        public void update()
        {
            listView.Items.Clear();
            foreach (Person person in model)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Vorname);
                item.SubItems.Add(person.TelefonNr);
                listView.Items.Add(item);
            }
        }
    }
}
